using System;

namespace OneSky.CSharp.Json
{
  internal class Plugin : IPlugin
  {
    public IPluginLocale Locale { get; private set; }

    public IPluginSpecialization Specialization { get; private set; }

    public IPluginProject Project { get; private set; }

    public IPluginQuotation Quotation { get; private set; }

    public IPluginAccount Account { get; private set; }

    public IPluginLanguagePair LanguagePair { get; private set; }

    public IPluginOrder Order { get; private set; }

    internal Plugin(CSharp.IPlugin plugin)
    {
      this.Locale = new PluginLocale(plugin.Locale);
      this.Specialization = new PluginSpecialization(plugin.Specialization);
      this.Project = new PluginProject(plugin.Project);
      this.Quotation = new PluginQuotation(plugin.Quotation);
      this.Account = new PluginAccount(plugin.Account, OneSkyClient.Anonymous);
      this.LanguagePair = new PluginLanguagePair(plugin.LanguagePair);
      this.Order = new PluginOrder(plugin.Order);
    }
  }
}