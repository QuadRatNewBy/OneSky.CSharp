using System;

namespace OneSky.CSharp
{
  internal class Plugin : IPlugin
  {
    internal Plugin(OneSkyHelper oneSky)
    {
      this.Locale = new PluginLocale(oneSky);
      this.Specialization = new PluginSpecialization(oneSky);
      this.Project = new PluginProject(oneSky);
      this.Quotation = new PluginQuotation(oneSky);
      this.Order = new PluginOrder(oneSky);
      this.Account = new PluginAccount(oneSky, OneSkyClient.Anonymous);
      this.LanguagePair = new PluginLanguagePair(oneSky);
    }

    public IPluginAccount Account { get; private set; }

    public IPluginLocale Locale { get; private set; }

    public IPluginSpecialization Specialization { get; private set; }

    public IPluginProject Project { get; private set; }

    public IPluginOrder Order { get; private set; }

    public IPluginQuotation Quotation { get; private set; }

    public IPluginLanguagePair LanguagePair { get; private set; }
  }
}