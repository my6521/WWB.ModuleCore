using WWB.ModuleCore.Context;

namespace WWB.ModuleCore
{

    /// <summary>
    /// 应用模块接口定义
    /// </summary>
    public interface IAppModule
    {
        /// <summary>
        /// 配置服务前
        /// </summary>
        /// <param name="context"></param>
        void OnPreConfigureServices(ServiceConfigurationContext context);

        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="context">配置上下文</param>
        void OnConfigureServices(ServiceConfigurationContext context);

        /// <summary>
        /// 配置服务后
        /// </summary>
        /// <param name="context"></param>
        void OnPostConfigureServices(ServiceConfigurationContext context);

        /// <summary>
        /// 应用启动前
        /// </summary>
        /// <param name="context"></param>
        void OnPreApplicationInitialization(ApplicationInitializationContext context);

        /// <summary>
        /// 应用启动
        /// </summary>
        /// <param name="context"></param>
        void OnApplicationInitialization(ApplicationInitializationContext context);

        /// <summary>
        /// 应用启动后
        /// </summary>
        /// <param name="context"></param>
        void OnPostApplicationInitialization(ApplicationInitializationContext context);

        /// <summary>
        /// 应用停止
        /// </summary>
        /// <param name="context"></param>
        void OnApplicationShutdown(ApplicationShutdownContext context);
    }

    public abstract class AppModule : IAppModule
    {
        /// <summary>
        /// 配置服务前
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnPreConfigureServices(ServiceConfigurationContext context)
        {
        }
        /// <summary>
        /// 配置服务
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnConfigureServices(ServiceConfigurationContext context)
        {

        }
        /// <summary>
        /// 配置服务后
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnPostConfigureServices(ServiceConfigurationContext context)
        {
        }
        /// <summary>
        /// 应用启动前
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnPreApplicationInitialization(ApplicationInitializationContext context)
        {
        }
        /// <summary>
        /// 应用启动
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnApplicationInitialization(ApplicationInitializationContext context)
        {
        }
        /// <summary>
        /// 应用启动后
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnPostApplicationInitialization(ApplicationInitializationContext context)
        {
        }
        /// <summary>
        /// 应用停止
        /// </summary>
        /// <param name="context"></param>
        public virtual void OnApplicationShutdown(ApplicationShutdownContext context)
        {

        }
    }
}
