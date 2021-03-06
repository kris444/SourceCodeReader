﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using SourceCodeReader.Web.Services;
using SourceCodeReader.Web.Services.GitHub;
using SourceCodeReader.Web.LanguageServices;
using SourceCodeReader.Web.LanguageServices.DotNet;

namespace SourceCodeReader.Web.Infrastructure
{
    public class ApplicationNinjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IEditorService>().To<DotNetCodeEditorService>();
            Bind<IApplicationConfigurationProvider>().To<ApplicationConfigurationProvider>();
            Bind<IFindReferenceProgress>().To<DefaultFindReferenceProgressListener>();
            Bind<IProjectDiscoveryService>().To<GitHubProjectDiscoveryService>();
            Bind<ISourceCodeOpeningProgress>().To<DefaultSourceCodeOpeningProgressListener>();
            Bind<ISourceCodeProviderService>().To<GitHubSourceCodeProviderService>();
        }
    }
}