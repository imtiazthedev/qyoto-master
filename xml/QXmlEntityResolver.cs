//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;

    public interface IQXmlEntityResolver {
        string ErrorString();
    }
    [SmokeClass("QXmlEntityResolver")]
    public abstract class QXmlEntityResolver : Object, IQXmlEntityResolver {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QXmlEntityResolver(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QXmlEntityResolver), this);
        }
        // bool resolveEntity(const QString& arg1,const QString& arg2,QXmlInputSource*& arg3); >>>> NOT CONVERTED
        [SmokeMethod("errorString() const")]
        public abstract string ErrorString();
        public QXmlEntityResolver() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QXmlEntityResolver", "QXmlEntityResolver()", typeof(void));
        }
    }
}