//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QPalette")]
    public class QPalette : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QPalette(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QPalette), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QPalette() {
            staticInterceptor = new SmokeInvocation(typeof(QPalette), null);
        }
        public enum ColorGroup {
            Active = 0,
            Disabled = 1,
            Inactive = 2,
            NColorGroups = 3,
            Current = 4,
            All = 5,
            Normal = Active,
        }
        public enum ColorRole {
            WindowText = 0,
            Button = 1,
            Light = 2,
            Midlight = 3,
            Dark = 4,
            Mid = 5,
            Text = 6,
            BrightText = 7,
            ButtonText = 8,
            Base = 9,
            Window = 10,
            Shadow = 11,
            Highlight = 12,
            HighlightedText = 13,
            Link = 14,
            LinkVisited = 15,
            AlternateBase = 16,
            NoRole = 17,
            ToolTipBase = 18,
            ToolTipText = 19,
            NColorRoles = ToolTipText+1,
            Foreground = WindowText,
            Background = Window,
        }
        //  operator QVariant(); >>>> NOT CONVERTED
        public QPalette() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette", "QPalette()", typeof(void));
        }
        public QPalette(QColor button) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette#", "QPalette(const QColor&)", typeof(void), typeof(QColor), button);
        }
        public QPalette(Qt.GlobalColor button) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette$", "QPalette(Qt::GlobalColor)", typeof(void), typeof(Qt.GlobalColor), button);
        }
        public QPalette(QColor button, QColor window) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette##", "QPalette(const QColor&, const QColor&)", typeof(void), typeof(QColor), button, typeof(QColor), window);
        }
        public QPalette(QBrush windowText, QBrush button, QBrush light, QBrush dark, QBrush mid, QBrush text, QBrush bright_text, QBrush arg8, QBrush window) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette#########", "QPalette(const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&)", typeof(void), typeof(QBrush), windowText, typeof(QBrush), button, typeof(QBrush), light, typeof(QBrush), dark, typeof(QBrush), mid, typeof(QBrush), text, typeof(QBrush), bright_text, typeof(QBrush), arg8, typeof(QBrush), window);
        }
        public QPalette(QColor windowText, QColor window, QColor light, QColor dark, QColor mid, QColor text, QColor arg7) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette#######", "QPalette(const QColor&, const QColor&, const QColor&, const QColor&, const QColor&, const QColor&, const QColor&)", typeof(void), typeof(QColor), windowText, typeof(QColor), window, typeof(QColor), light, typeof(QColor), dark, typeof(QColor), mid, typeof(QColor), text, typeof(QColor), arg7);
        }
        public QPalette(QPalette palette) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QPalette#", "QPalette(const QPalette&)", typeof(void), typeof(QPalette), palette);
        }
        public QPalette.ColorGroup CurrentColorGroup() {
            return (QPalette.ColorGroup) interceptor.Invoke("currentColorGroup", "currentColorGroup() const", typeof(QPalette.ColorGroup));
        }
        public void SetCurrentColorGroup(QPalette.ColorGroup cg) {
            interceptor.Invoke("setCurrentColorGroup$", "setCurrentColorGroup(QPalette::ColorGroup)", typeof(void), typeof(QPalette.ColorGroup), cg);
        }
        public QColor Color(QPalette.ColorGroup cg, QPalette.ColorRole cr) {
            return (QColor) interceptor.Invoke("color$$", "color(QPalette::ColorGroup, QPalette::ColorRole) const", typeof(QColor), typeof(QPalette.ColorGroup), cg, typeof(QPalette.ColorRole), cr);
        }
        public QBrush Brush(QPalette.ColorGroup cg, QPalette.ColorRole cr) {
            return (QBrush) interceptor.Invoke("brush$$", "brush(QPalette::ColorGroup, QPalette::ColorRole) const", typeof(QBrush), typeof(QPalette.ColorGroup), cg, typeof(QPalette.ColorRole), cr);
        }
        public void SetColor(QPalette.ColorGroup cg, QPalette.ColorRole cr, QColor color) {
            interceptor.Invoke("setColor$$#", "setColor(QPalette::ColorGroup, QPalette::ColorRole, const QColor&)", typeof(void), typeof(QPalette.ColorGroup), cg, typeof(QPalette.ColorRole), cr, typeof(QColor), color);
        }
        public void SetColor(QPalette.ColorRole cr, QColor color) {
            interceptor.Invoke("setColor$#", "setColor(QPalette::ColorRole, const QColor&)", typeof(void), typeof(QPalette.ColorRole), cr, typeof(QColor), color);
        }
        public void SetBrush(QPalette.ColorRole cr, QBrush brush) {
            interceptor.Invoke("setBrush$#", "setBrush(QPalette::ColorRole, const QBrush&)", typeof(void), typeof(QPalette.ColorRole), cr, typeof(QBrush), brush);
        }
        public bool IsBrushSet(QPalette.ColorGroup cg, QPalette.ColorRole cr) {
            return (bool) interceptor.Invoke("isBrushSet$$", "isBrushSet(QPalette::ColorGroup, QPalette::ColorRole) const", typeof(bool), typeof(QPalette.ColorGroup), cg, typeof(QPalette.ColorRole), cr);
        }
        public void SetBrush(QPalette.ColorGroup cg, QPalette.ColorRole cr, QBrush brush) {
            interceptor.Invoke("setBrush$$#", "setBrush(QPalette::ColorGroup, QPalette::ColorRole, const QBrush&)", typeof(void), typeof(QPalette.ColorGroup), cg, typeof(QPalette.ColorRole), cr, typeof(QBrush), brush);
        }
        public void SetColorGroup(QPalette.ColorGroup cr, QBrush windowText, QBrush button, QBrush light, QBrush dark, QBrush mid, QBrush text, QBrush bright_text, QBrush arg9, QBrush window) {
            interceptor.Invoke("setColorGroup$#########", "setColorGroup(QPalette::ColorGroup, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&, const QBrush&)", typeof(void), typeof(QPalette.ColorGroup), cr, typeof(QBrush), windowText, typeof(QBrush), button, typeof(QBrush), light, typeof(QBrush), dark, typeof(QBrush), mid, typeof(QBrush), text, typeof(QBrush), bright_text, typeof(QBrush), arg9, typeof(QBrush), window);
        }
        public bool IsEqual(QPalette.ColorGroup cr1, QPalette.ColorGroup cr2) {
            return (bool) interceptor.Invoke("isEqual$$", "isEqual(QPalette::ColorGroup, QPalette::ColorGroup) const", typeof(bool), typeof(QPalette.ColorGroup), cr1, typeof(QPalette.ColorGroup), cr2);
        }
        public QColor Color(QPalette.ColorRole cr) {
            return (QColor) interceptor.Invoke("color$", "color(QPalette::ColorRole) const", typeof(QColor), typeof(QPalette.ColorRole), cr);
        }
        public QBrush Brush(QPalette.ColorRole cr) {
            return (QBrush) interceptor.Invoke("brush$", "brush(QPalette::ColorRole) const", typeof(QBrush), typeof(QPalette.ColorRole), cr);
        }
        public QBrush Foreground() {
            return (QBrush) interceptor.Invoke("foreground", "foreground() const", typeof(QBrush));
        }
        public QBrush WindowText() {
            return (QBrush) interceptor.Invoke("windowText", "windowText() const", typeof(QBrush));
        }
        public QBrush Button() {
            return (QBrush) interceptor.Invoke("button", "button() const", typeof(QBrush));
        }
        public QBrush Light() {
            return (QBrush) interceptor.Invoke("light", "light() const", typeof(QBrush));
        }
        public QBrush Dark() {
            return (QBrush) interceptor.Invoke("dark", "dark() const", typeof(QBrush));
        }
        public QBrush Mid() {
            return (QBrush) interceptor.Invoke("mid", "mid() const", typeof(QBrush));
        }
        public QBrush Text() {
            return (QBrush) interceptor.Invoke("text", "text() const", typeof(QBrush));
        }
        public QBrush Base() {
            return (QBrush) interceptor.Invoke("base", "base() const", typeof(QBrush));
        }
        public QBrush AlternateBase() {
            return (QBrush) interceptor.Invoke("alternateBase", "alternateBase() const", typeof(QBrush));
        }
        public QBrush ToolTipBase() {
            return (QBrush) interceptor.Invoke("toolTipBase", "toolTipBase() const", typeof(QBrush));
        }
        public QBrush ToolTipText() {
            return (QBrush) interceptor.Invoke("toolTipText", "toolTipText() const", typeof(QBrush));
        }
        public QBrush Background() {
            return (QBrush) interceptor.Invoke("background", "background() const", typeof(QBrush));
        }
        public QBrush Window() {
            return (QBrush) interceptor.Invoke("window", "window() const", typeof(QBrush));
        }
        public QBrush Midlight() {
            return (QBrush) interceptor.Invoke("midlight", "midlight() const", typeof(QBrush));
        }
        public QBrush BrightText() {
            return (QBrush) interceptor.Invoke("brightText", "brightText() const", typeof(QBrush));
        }
        public QBrush ButtonText() {
            return (QBrush) interceptor.Invoke("buttonText", "buttonText() const", typeof(QBrush));
        }
        public QBrush Shadow() {
            return (QBrush) interceptor.Invoke("shadow", "shadow() const", typeof(QBrush));
        }
        public QBrush Highlight() {
            return (QBrush) interceptor.Invoke("highlight", "highlight() const", typeof(QBrush));
        }
        public QBrush HighlightedText() {
            return (QBrush) interceptor.Invoke("highlightedText", "highlightedText() const", typeof(QBrush));
        }
        public QBrush Link() {
            return (QBrush) interceptor.Invoke("link", "link() const", typeof(QBrush));
        }
        public QBrush LinkVisited() {
            return (QBrush) interceptor.Invoke("linkVisited", "linkVisited() const", typeof(QBrush));
        }
        public override bool Equals(object o) {
            if (!(o is QPalette)) { return false; }
            return this == (QPalette) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public bool IsCopyOf(QPalette p) {
            return (bool) interceptor.Invoke("isCopyOf#", "isCopyOf(const QPalette&) const", typeof(bool), typeof(QPalette), p);
        }
        public int SerialNumber() {
            return (int) interceptor.Invoke("serialNumber", "serialNumber() const", typeof(int));
        }
        public long CacheKey() {
            return (long) interceptor.Invoke("cacheKey", "cacheKey() const", typeof(long));
        }
        public QPalette Resolve(QPalette arg1) {
            return (QPalette) interceptor.Invoke("resolve#", "resolve(const QPalette&) const", typeof(QPalette), typeof(QPalette), arg1);
        }
        public uint Resolve() {
            return (uint) interceptor.Invoke("resolve", "resolve() const", typeof(uint));
        }
        public void Resolve(uint mask) {
            interceptor.Invoke("resolve$", "resolve(uint)", typeof(void), typeof(uint), mask);
        }
        ~QPalette() {
            interceptor.Invoke("~QPalette", "~QPalette()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QPalette", "~QPalette()", typeof(void));
        }
        public static bool operator==(QPalette lhs, QPalette p) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QPalette&) const", typeof(bool), typeof(QPalette), lhs, typeof(QPalette), p);
        }
        public static bool operator!=(QPalette lhs, QPalette p) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QPalette&) const", typeof(bool), typeof(QPalette), lhs, typeof(QPalette), p);
        }
    }
}
