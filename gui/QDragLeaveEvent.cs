//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QDragLeaveEvent")]
    public class QDragLeaveEvent : QEvent, IDisposable {
        protected QDragLeaveEvent(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDragLeaveEvent), this);
        }
        public QDragLeaveEvent() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDragLeaveEvent", "QDragLeaveEvent()", typeof(void));
        }
        ~QDragLeaveEvent() {
            interceptor.Invoke("~QDragLeaveEvent", "~QDragLeaveEvent()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDragLeaveEvent", "~QDragLeaveEvent()", typeof(void));
        }
    }
}