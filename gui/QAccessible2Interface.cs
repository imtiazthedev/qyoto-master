//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QAccessible2Interface")]
    public class QAccessible2Interface : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QAccessible2Interface(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QAccessible2Interface), this);
        }
        public QAccessible2Interface() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAccessible2Interface", "QAccessible2Interface()", typeof(void));
        }
        ~QAccessible2Interface() {
            interceptor.Invoke("~QAccessible2Interface", "~QAccessible2Interface()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QAccessible2Interface", "~QAccessible2Interface()", typeof(void));
        }
    }
}
