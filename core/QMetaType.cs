//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QMetaType")]
    public partial class QMetaType : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QMetaType(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QMetaType), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QMetaType() {
            staticInterceptor = new SmokeInvocation(typeof(QMetaType), null);
        }
        public enum TypeOf {
            Void = 0,
            Bool = 1,
            Int = 2,
            UInt = 3,
            LongLong = 4,
            ULongLong = 5,
            Double = 6,
            QChar = 7,
            QVariantMap = 8,
            QVariantList = 9,
            QString = 10,
            QStringList = 11,
            QByteArray = 12,
            QBitArray = 13,
            QDate = 14,
            QTime = 15,
            QDateTime = 16,
            QUrl = 17,
            QLocale = 18,
            QRect = 19,
            QRectF = 20,
            QSize = 21,
            QSizeF = 22,
            QLine = 23,
            QLineF = 24,
            QPoint = 25,
            QPointF = 26,
            QRegExp = 27,
            QVariantHash = 28,
            LastCoreType = 28,
            FirstGuiType = 63,
            QFont = 64,
            QPixmap = 65,
            QBrush = 66,
            QColor = 67,
            QPalette = 68,
            QIcon = 69,
            QImage = 70,
            QPolygon = 71,
            QRegion = 72,
            QBitmap = 73,
            QCursor = 74,
            QSizePolicy = 75,
            QKeySequence = 76,
            QPen = 77,
            QTextLength = 78,
            QTextFormat = 79,
            QMatrix = 80,
            QTransform = 81,
            LastGuiType = 81,
            FirstCoreExtType = 128,
            VoidStar = 128,
            Long = 129,
            Short = 130,
            Char = 131,
            ULong = 132,
            UShort = 133,
            UChar = 134,
            Float = 135,
            QObjectStar = 136,
            QWidgetStar = 137,
            LastCoreExtType = 137,
            User = 256,
        }
        // void registerStreamOperators(const char* arg1,SaveOperator arg2,LoadOperator arg3); >>>> NOT CONVERTED
        // int registerType(const char* arg1,Destructor arg2,Constructor arg3); >>>> NOT CONVERTED
        // void* construct(int arg1,const void* arg2); >>>> NOT CONVERTED
        // void* construct(int arg1); >>>> NOT CONVERTED
        // void destroy(int arg1,void* arg2); >>>> NOT CONVERTED
        // bool save(QDataStream& arg1,int arg2,const void* arg3); >>>> NOT CONVERTED
        // bool load(QDataStream& arg1,int arg2,void* arg3); >>>> NOT CONVERTED
        public QMetaType() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QMetaType", "QMetaType()", typeof(void));
        }
        ~QMetaType() {
            interceptor.Invoke("~QMetaType", "~QMetaType()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QMetaType", "~QMetaType()", typeof(void));
        }
        public static int type(string typeName) {
            return (int) staticInterceptor.Invoke("type$", "type(const char*)", typeof(int), typeof(string), typeName);
        }
        public static string TypeName(int type) {
            return (string) staticInterceptor.Invoke("typeName$", "typeName(int)", typeof(string), typeof(int), type);
        }
        public static bool IsRegistered(int type) {
            return (bool) staticInterceptor.Invoke("isRegistered$", "isRegistered(int)", typeof(bool), typeof(int), type);
        }
        public static void UnregisterType(string typeName) {
            staticInterceptor.Invoke("unregisterType$", "unregisterType(const char*)", typeof(void), typeof(string), typeName);
        }
    }
}
