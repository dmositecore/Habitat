﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecore.Foundation.MultiSite.Tests.Pipelines
{
  using FluentAssertions;
  using NSubstitute;
  using Ploeh.AutoFixture.AutoNSubstitute;
  using Ploeh.AutoFixture.Xunit2;
  using Sitecore.Data;
  using Sitecore.Data.Items;
  using Sitecore.FakeDb;
  using Sitecore.Foundation.MultiSite.Pipelines;
  using Sitecore.Foundation.MultiSite.Providers;
  using Sitecore.Foundation.MultiSite.Tests.Extensions;
  using Sitecore.Pipelines.GetRenderingDatasource;
  using Xunit;

  public class GetDatasourceLocationAndTemplateFromSiteTests
  {
    [Theory]
    [AutoDbData]
    public void Process_DatasourceProvidersAreNull_SourcesAndTemplateAreNotSet([Frozen]DatasourceProviderFactory factory, GetDatasourceLocationAndTemplateFromSite processor, DbItem renderingItem, Db db, string settingName)
    {
      var setting = settingName.Replace("-", string.Empty);
      renderingItem.Add(new DbField("Datasource Location") { {"en", $"site:{setting}"} });
      db.Add(renderingItem);
      var rendering = db.GetItem(renderingItem.ID);
      var args = new GetRenderingDatasourceArgs(rendering);
      processor.Process(args);
      args.DatasourceRoots.Count.Should().Be(0);
      args.Prototype.Should().BeNull();
    }

    [Theory]
    [AutoDbData]
    public void Process_DatasourceProviderIsNotNull_SourcesAndTemplateAreSet(IDatasourceProvider sourceProvider, [Substitute]DatasourceProviderFactory factory, DbItem renderingItem, Db db, string settingName, Item[] sources, Item sourceTemplate)
    {
      var processor  = new GetDatasourceLocationAndTemplateFromSite(factory);
      sourceProvider.GetDatasources(Arg.Any<string>(), Arg.Any<Item>()).Returns(sources);
      sourceProvider.GetDatasourceTemplate(Arg.Any<string>(), Arg.Any<Item>()).Returns(sourceTemplate);
      factory.GetProvider(Arg.Any<Database>()).Returns(sourceProvider);
      var setting = settingName.Replace("-", string.Empty);
      renderingItem.Add(new DbField("Datasource Location") { { "en", $"site:{setting}" } });
      db.Add(renderingItem);
      var rendering = db.GetItem(renderingItem.ID);
      var args = new GetRenderingDatasourceArgs(rendering);
      processor.Process(args);
      args.DatasourceRoots.Should().Contain(sources);
      args.Prototype.Should().Be(sourceTemplate);
    }

    [Theory]
    [AutoDbData]
    public void Process_FallbackDatasourceProviderIsNotNull_SourcesAndTemplateAreSet(IDatasourceProvider sourceProvider, [Substitute]DatasourceProviderFactory factory, DbItem renderingItem, Db db, string settingName, Item[] sources, Item sourceTemplate)
    {
      var processor = new GetDatasourceLocationAndTemplateFromSite(factory);
      sourceProvider.GetDatasources(Arg.Any<string>(), Arg.Any<Item>()).Returns(sources);
      sourceProvider.GetDatasourceTemplate(Arg.Any<string>(), Arg.Any<Item>()).Returns(sourceTemplate);
      factory.GetProvider(Arg.Any<Database>()).Returns((IDatasourceProvider)null);
      factory.GetFallbackProvider(Arg.Any<Database>()).Returns(sourceProvider);
      var setting = settingName.Replace("-", string.Empty);
      renderingItem.Add(new DbField("Datasource Location") { { "en", $"site:{setting}" } });
      db.Add(renderingItem);
      var rendering = db.GetItem(renderingItem.ID);
      var args = new GetRenderingDatasourceArgs(rendering);
      processor.Process(args);
      args.DatasourceRoots.Should().Contain(sources);
      args.Prototype.Should().Be(sourceTemplate);
    }

    [Theory]
    [AutoDbData]
    public void Process_SiteSettingIsNotSet_SourcesAndTemplateAreNotSet([Frozen]DatasourceProviderFactory factory, GetDatasourceLocationAndTemplateFromSite processor, Item renderingItem)
    {
      var args = new GetRenderingDatasourceArgs(renderingItem);
      processor.Process(args);
      args.DatasourceRoots.Count.Should().Be(0);
      args.Prototype.Should().BeNull();
    }

    [Theory]
    [AutoDbData]
    public void Process_SiteSettingNameHasWrongFirmat_SourcesAndTemplateAreNotSet([Frozen]DatasourceProviderFactory factory, GetDatasourceLocationAndTemplateFromSite processor, DbItem renderingItem, Db db, string settingName)
    {
      renderingItem.Add(new DbField("Datasource Location") { { "en", $"site:{settingName}" } });
      db.Add(renderingItem);
      var rendering = db.GetItem(renderingItem.ID);
      var args = new GetRenderingDatasourceArgs(rendering);
      processor.Process(args);
      args.DatasourceRoots.Count.Should().Be(0);
      args.Prototype.Should().BeNull();
    }
  }
}
