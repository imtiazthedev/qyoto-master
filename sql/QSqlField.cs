//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QSqlField")]
    public class QSqlField : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QSqlField(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QSqlField), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QSqlField() {
            staticInterceptor = new SmokeInvocation(typeof(QSqlField), null);
        }
        public enum RequiredStatus {
            Unknown = -1,
            Optional = 0,
            Required = 1,
        }
        public QSqlField(string fieldName, QVariant.TypeOf type) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlField$$", "QSqlField(const QString&, QVariant::Type)", typeof(void), typeof(string), fieldName, typeof(QVariant.TypeOf), type);
        }
        public QSqlField(string fieldName) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlField$", "QSqlField(const QString&)", typeof(void), typeof(string), fieldName);
        }
        public QSqlField() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlField", "QSqlField()", typeof(void));
        }
        public QSqlField(QSqlField other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QSqlField#", "QSqlField(const QSqlField&)", typeof(void), typeof(QSqlField), other);
        }
        public override bool Equals(object o) {
            if (!(o is QSqlField)) { return false; }
            return this == (QSqlField) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public void SetValue(QVariant value) {
            interceptor.Invoke("setValue#", "setValue(const QVariant&)", typeof(void), typeof(QVariant), value);
        }
        public QVariant Value() {
            return (QVariant) interceptor.Invoke("value", "value() const", typeof(QVariant));
        }
        public void SetName(string name) {
            interceptor.Invoke("setName$", "setName(const QString&)", typeof(void), typeof(string), name);
        }
        public string Name() {
            return (string) interceptor.Invoke("name", "name() const", typeof(string));
        }
        public bool IsNull() {
            return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
        }
        public void SetReadOnly(bool readOnly) {
            interceptor.Invoke("setReadOnly$", "setReadOnly(bool)", typeof(void), typeof(bool), readOnly);
        }
        public bool IsReadOnly() {
            return (bool) interceptor.Invoke("isReadOnly", "isReadOnly() const", typeof(bool));
        }
        public void Clear() {
            interceptor.Invoke("clear", "clear()", typeof(void));
        }
        public QVariant.TypeOf type() {
            return (QVariant.TypeOf) interceptor.Invoke("type", "type() const", typeof(QVariant.TypeOf));
        }
        public bool IsAutoValue() {
            return (bool) interceptor.Invoke("isAutoValue", "isAutoValue() const", typeof(bool));
        }
        public void SetType(QVariant.TypeOf type) {
            interceptor.Invoke("setType$", "setType(QVariant::Type)", typeof(void), typeof(QVariant.TypeOf), type);
        }
        public void SetRequiredStatus(QSqlField.RequiredStatus status) {
            interceptor.Invoke("setRequiredStatus$", "setRequiredStatus(QSqlField::RequiredStatus)", typeof(void), typeof(QSqlField.RequiredStatus), status);
        }
        public void SetRequired(bool required) {
            interceptor.Invoke("setRequired$", "setRequired(bool)", typeof(void), typeof(bool), required);
        }
        public void SetLength(int fieldLength) {
            interceptor.Invoke("setLength$", "setLength(int)", typeof(void), typeof(int), fieldLength);
        }
        public void SetPrecision(int precision) {
            interceptor.Invoke("setPrecision$", "setPrecision(int)", typeof(void), typeof(int), precision);
        }
        public void SetDefaultValue(QVariant value) {
            interceptor.Invoke("setDefaultValue#", "setDefaultValue(const QVariant&)", typeof(void), typeof(QVariant), value);
        }
        public void SetSqlType(int type) {
            interceptor.Invoke("setSqlType$", "setSqlType(int)", typeof(void), typeof(int), type);
        }
        public void SetGenerated(bool gen) {
            interceptor.Invoke("setGenerated$", "setGenerated(bool)", typeof(void), typeof(bool), gen);
        }
        public void SetAutoValue(bool autoVal) {
            interceptor.Invoke("setAutoValue$", "setAutoValue(bool)", typeof(void), typeof(bool), autoVal);
        }
        public QSqlField.RequiredStatus requiredStatus() {
            return (QSqlField.RequiredStatus) interceptor.Invoke("requiredStatus", "requiredStatus() const", typeof(QSqlField.RequiredStatus));
        }
        public int Length() {
            return (int) interceptor.Invoke("length", "length() const", typeof(int));
        }
        public int Precision() {
            return (int) interceptor.Invoke("precision", "precision() const", typeof(int));
        }
        public QVariant DefaultValue() {
            return (QVariant) interceptor.Invoke("defaultValue", "defaultValue() const", typeof(QVariant));
        }
        public int TypeID() {
            return (int) interceptor.Invoke("typeID", "typeID() const", typeof(int));
        }
        public bool IsGenerated() {
            return (bool) interceptor.Invoke("isGenerated", "isGenerated() const", typeof(bool));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        ~QSqlField() {
            interceptor.Invoke("~QSqlField", "~QSqlField()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QSqlField", "~QSqlField()", typeof(void));
        }
        public static bool operator==(QSqlField lhs, QSqlField other) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QSqlField&) const", typeof(bool), typeof(QSqlField), lhs, typeof(QSqlField), other);
        }
        public static bool operator!=(QSqlField lhs, QSqlField other) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QSqlField&) const", typeof(bool), typeof(QSqlField), lhs, typeof(QSqlField), other);
        }
    }
}
