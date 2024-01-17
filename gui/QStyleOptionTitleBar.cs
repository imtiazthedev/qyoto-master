//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QStyleOptionTitleBar")]
    public class QStyleOptionTitleBar : QStyleOptionComplex, IDisposable {
        protected QStyleOptionTitleBar(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QStyleOptionTitleBar), this);
        }
        public enum StyleOptionType {
            Type = QStyleOption.OptionType.SO_TitleBar,
        }
        public enum StyleOptionVersion {
            Version = 1,
        }
        public string Text {
            get { return (string) interceptor.Invoke("text", "text()", typeof(string)); }
            set { interceptor.Invoke("setText$", "setText(QString)", typeof(void), typeof(string), value); }
        }
        public QIcon Icon {
            get { return (QIcon) interceptor.Invoke("icon", "icon()", typeof(QIcon)); }
            set { interceptor.Invoke("setIcon#", "setIcon(QIcon)", typeof(void), typeof(QIcon), value); }
        }
        public int TitleBarState {
            get { return (int) interceptor.Invoke("titleBarState", "titleBarState()", typeof(int)); }
            set { interceptor.Invoke("setTitleBarState$", "setTitleBarState(int)", typeof(void), typeof(int), value); }
        }
        public uint TitleBarFlags {
            get { return (uint) interceptor.Invoke("titleBarFlags", "titleBarFlags()", typeof(uint)); }
            set { interceptor.Invoke("setTitleBarFlags$", "setTitleBarFlags(Qt::WindowFlags)", typeof(void), typeof(uint), value); }
        }
        public QStyleOptionTitleBar() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTitleBar", "QStyleOptionTitleBar()", typeof(void));
        }
        public QStyleOptionTitleBar(QStyleOptionTitleBar other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTitleBar#", "QStyleOptionTitleBar(const QStyleOptionTitleBar&)", typeof(void), typeof(QStyleOptionTitleBar), other);
        }
        public QStyleOptionTitleBar(int version) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QStyleOptionTitleBar$", "QStyleOptionTitleBar(int)", typeof(void), typeof(int), version);
        }
        ~QStyleOptionTitleBar() {
            interceptor.Invoke("~QStyleOptionTitleBar", "~QStyleOptionTitleBar()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QStyleOptionTitleBar", "~QStyleOptionTitleBar()", typeof(void));
        }
    }
}