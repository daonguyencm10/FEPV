﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES.Infrastructure.Library.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MES.Infrastructure.Library.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 AddServices() method called for Module {0}. 的本地化字符串。
        /// </summary>
        internal static string AddServicesCalled {
            get {
                return ResourceManager.GetString("AddServicesCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Section &apos;{0}&apos; depends on section &apos;{1}&apos; which was not found. 的本地化字符串。
        /// </summary>
        internal static string DependencyNotFound {
            get {
                return ResourceManager.GetString("DependencyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A duplicated module with name {0} has been found by the loader. 的本地化字符串。
        /// </summary>
        internal static string DuplicatedModule {
            get {
                return ResourceManager.GetString("DuplicatedModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to load module from assembly {0}. Error was:
        ///{1} 的本地化字符串。
        /// </summary>
        internal static string FailedToLoadModule {
            get {
                return ResourceManager.GetString("FailedToLoadModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The solution profile references an unknown schema. 的本地化字符串。
        /// </summary>
        internal static string InvalidSolutionProfileSchema {
            get {
                return ResourceManager.GetString("InvalidSolutionProfileSchema", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Module {0} added to the container. 的本地化字符串。
        /// </summary>
        internal static string LogModuleAdded {
            get {
                return ResourceManager.GetString("LogModuleAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Loaded assembly file {0} for Module. 的本地化字符串。
        /// </summary>
        internal static string LogModuleAssemblyLoaded {
            get {
                return ResourceManager.GetString("LogModuleAssemblyLoaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Assembly file {0} was not found. 的本地化字符串。
        /// </summary>
        internal static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Load() method called for Module {0}. 的本地化字符串。
        /// </summary>
        internal static string ModuleStartCalled {
            get {
                return ResourceManager.GetString("ModuleStartCalled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 No user was selected for the authentication service. 的本地化字符串。
        /// </summary>
        internal static string NoUserProvidedForAuthentication {
            get {
                return ResourceManager.GetString("NoUserProvidedForAuthentication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The ModuleLoaderService cannot initialize the module because some of their dependencies are not present. Make sure to deploy all the assemblies needed to execute the module. 的本地化字符串。
        /// </summary>
        internal static string ReferencedAssemblyNotFound {
            get {
                return ResourceManager.GetString("ReferencedAssemblyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Service {1} added for Module {0}. 的本地化字符串。
        /// </summary>
        internal static string ServiceAdded {
            get {
                return ResourceManager.GetString("ServiceAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Service {1} will be added on demand for Module {0}. 的本地化字符串。
        /// </summary>
        internal static string ServiceAddedOnDemand {
            get {
                return ResourceManager.GetString("ServiceAddedOnDemand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There is no a user matching the information you have provided. 的本地化字符串。
        /// </summary>
        internal static string UserNotFoundMessage {
            get {
                return ResourceManager.GetString("UserNotFoundMessage", resourceCulture);
            }
        }
    }
}
