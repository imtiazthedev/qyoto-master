//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Collections.Generic;
    [SmokeClass("QWidgetAction")]
    public class QWidgetAction : QAction, IDisposable {
        protected QWidgetAction(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QWidgetAction), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QWidgetAction() {
            staticInterceptor = new SmokeInvocation(typeof(QWidgetAction), null);
        }
        public QWidgetAction(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QWidgetAction#", "QWidgetAction(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public void SetDefaultWidget(QWidget w) {
            interceptor.Invoke("setDefaultWidget#", "setDefaultWidget(QWidget*)", typeof(void), typeof(QWidget), w);
        }
        public QWidget DefaultWidget() {
            return (QWidget) interceptor.Invoke("defaultWidget", "defaultWidget() const", typeof(QWidget));
        }
        public QWidget RequestWidget(QWidget parent) {
            return (QWidget) interceptor.Invoke("requestWidget#", "requestWidget(QWidget*)", typeof(QWidget), typeof(QWidget), parent);
        }
        public void ReleaseWidget(QWidget widget) {
            interceptor.Invoke("releaseWidget#", "releaseWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        [SmokeMethod("event(QEvent*)")]
        protected override bool Event(QEvent arg1) {
            return (bool) interceptor.Invoke("event#", "event(QEvent*)", typeof(bool), typeof(QEvent), arg1);
        }
        [SmokeMethod("eventFilter(QObject*, QEvent*)")]
        protected new virtual bool EventFilter(QObject arg1, QEvent arg2) {
            return (bool) interceptor.Invoke("eventFilter##", "eventFilter(QObject*, QEvent*)", typeof(bool), typeof(QObject), arg1, typeof(QEvent), arg2);
        }
        [SmokeMethod("createWidget(QWidget*)")]
        protected virtual QWidget CreateWidget(QWidget parent) {
            return (QWidget) interceptor.Invoke("createWidget#", "createWidget(QWidget*)", typeof(QWidget), typeof(QWidget), parent);
        }
        [SmokeMethod("deleteWidget(QWidget*)")]
        protected virtual void DeleteWidget(QWidget widget) {
            interceptor.Invoke("deleteWidget#", "deleteWidget(QWidget*)", typeof(void), typeof(QWidget), widget);
        }
        protected List<QWidget> CreatedWidgets() {
            return (List<QWidget>) interceptor.Invoke("createdWidgets", "createdWidgets() const", typeof(List<QWidget>));
        }
        ~QWidgetAction() {
            interceptor.Invoke("~QWidgetAction", "~QWidgetAction()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QWidgetAction", "~QWidgetAction()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQWidgetActionSignals Emit {
            get { return (IQWidgetActionSignals) Q_EMIT; }
        }
    }

    public interface IQWidgetActionSignals : IQActionSignals {
    }
}