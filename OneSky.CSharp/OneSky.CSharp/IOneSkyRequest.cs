/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
namespace OneSky.CSharp
{
    interface IOneSkyRequest
    {
        IOneSkyRequest Placeholder(string placeholder, object value, bool condition = true);

        IOneSkyRequest Parameter(string parameter, object value, bool condition = true);

        IOneSkyRequest Body(string key, object value, bool condition = true);

        IOneSkyRequest Files(string name, string path, bool condition = true);

        IOneSkyResponse Get();

        IOneSkyResponse Post();

        IOneSkyResponse Put();

        IOneSkyResponse Delete();
    }
}
