//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTestAccessibilityEvent")]
    public class QTestAccessibilityEvent : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTestAccessibilityEvent(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTestAccessibilityEvent), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTestAccessibilityEvent() {
            staticInterceptor = new SmokeInvocation(typeof(QTestAccessibilityEvent), null);
        }
        public QObject Object {
            get { return (QObject) interceptor.Invoke("object", "object()", typeof(QObject)); }
            set { interceptor.Invoke("setObject#", "setObject(QObject*)", typeof(void), typeof(QObject), value); }
        }
        public int Child {
            get { return (int) interceptor.Invoke("child", "child()", typeof(int)); }
            set { interceptor.Invoke("setChild$", "setChild(int)", typeof(void), typeof(int), value); }
        }
        public int Event {
            get { return (int) interceptor.Invoke("event", "event()", typeof(int)); }
            set { interceptor.Invoke("setEvent$", "setEvent(int)", typeof(void), typeof(int), value); }
        }
        public QTestAccessibilityEvent(QObject o, int c, int e) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTestAccessibilityEvent#$$", "QTestAccessibilityEvent(QObject*, int, int)", typeof(void), typeof(QObject), o, typeof(int), c, typeof(int), e);
        }
        public QTestAccessibilityEvent(QObject o, int c) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTestAccessibilityEvent#$", "QTestAccessibilityEvent(QObject*, int)", typeof(void), typeof(QObject), o, typeof(int), c);
        }
        public QTestAccessibilityEvent(QObject o) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTestAccessibilityEvent#", "QTestAccessibilityEvent(QObject*)", typeof(void), typeof(QObject), o);
        }
        public QTestAccessibilityEvent() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTestAccessibilityEvent", "QTestAccessibilityEvent()", typeof(void));
        }
        public override bool Equals(object o) {
            if (!(o is QTestAccessibilityEvent)) { return false; }
            return this == (QTestAccessibilityEvent) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        ~QTestAccessibilityEvent() {
            interceptor.Invoke("~QTestAccessibilityEvent", "~QTestAccessibilityEvent()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTestAccessibilityEvent", "~QTestAccessibilityEvent()", typeof(void));
        }
        public static bool operator==(QTestAccessibilityEvent lhs, QTestAccessibilityEvent o) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QTestAccessibilityEvent&) const", typeof(bool), typeof(QTestAccessibilityEvent), lhs, typeof(QTestAccessibilityEvent), o);
        }
        public static bool operator!=(QTestAccessibilityEvent lhs, QTestAccessibilityEvent o) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QTestAccessibilityEvent&) const", typeof(bool), typeof(QTestAccessibilityEvent), lhs, typeof(QTestAccessibilityEvent), o);
        }
    }
}
