namespace OneSkyDotNet.Json
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    internal class PlatformProjectType : IPlatformProjectType
    {
        private OneSkyDotNet.IPlatformProjectType projectType;

        public PlatformProjectType(OneSkyDotNet.IPlatformProjectType projectType)
        {
            this.projectType = projectType;
        }

        public IOneSkyResponse<IMetaList, IEnumerable<IProjectType>> List()
        {
            var plainResponse = this.projectType.List();
            var jsonResponseMeta = JsonConvert.DeserializeAnonymousType(
                plainResponse.Content,
                new { meta = new MetaList() });

            var data = new List<ProjectType>();

            if (jsonResponseMeta.meta.Status >= 200 && jsonResponseMeta.meta.Status < 300)
            {
                var jsonResponseData = JsonConvert.DeserializeAnonymousType(
                    plainResponse.Content,
                    new { data = new List<ProjectType>() });

                data = jsonResponseData.data;
            }

            return new OneSkyResponse<IMetaList, IEnumerable<IProjectType>>(
                plainResponse.StatusCode,
                plainResponse.StatusDescription,
                jsonResponseMeta.meta,
                data);
        }
    }
}