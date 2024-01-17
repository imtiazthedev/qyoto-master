//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Collections.Generic;
    [SmokeClass("QDBusArgument")]
    public class QDBusArgument : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QDBusArgument(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDBusArgument), this);
        }
        public enum ElementType {
            BasicType = 0,
            VariantType = 1,
            ArrayType = 2,
            StructureType = 3,
            MapType = 4,
            MapEntryType = 5,
            UnknownType = -1,
        }
        // const QDBusArgument& operator>>(qlonglong& arg1); >>>> NOT CONVERTED
        // const QDBusArgument& operator>>(qulonglong& arg1); >>>> NOT CONVERTED
        // QDBusArgument* QDBusArgument(QDBusArgumentPrivate* arg1); >>>> NOT CONVERTED
        public QDBusArgument() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDBusArgument", "QDBusArgument()", typeof(void));
        }
        public QDBusArgument(QDBusArgument other) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDBusArgument#", "QDBusArgument(const QDBusArgument&)", typeof(void), typeof(QDBusArgument), other);
        }
        public QDBusArgument Write(ushort arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(uchar)", typeof(QDBusArgument), typeof(ushort), arg);
        }
        public QDBusArgument Write(bool arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(bool)", typeof(QDBusArgument), typeof(bool), arg);
        }
        public QDBusArgument Write(short arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(short)", typeof(QDBusArgument), typeof(short), arg);
        }
        public QDBusArgument Write(int arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(int)", typeof(QDBusArgument), typeof(int), arg);
        }
        public QDBusArgument Write(uint arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(uint)", typeof(QDBusArgument), typeof(uint), arg);
        }
        public QDBusArgument Write(long arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<?", "operator<<(qlonglong)", typeof(QDBusArgument), typeof(long), arg);
        }
        public QDBusArgument Write(ulong arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(qulonglong)", typeof(QDBusArgument), typeof(ulong), arg);
        }
        public QDBusArgument Write(double arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(double)", typeof(QDBusArgument), typeof(double), arg);
        }
        public QDBusArgument Write(string arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(const QString&)", typeof(QDBusArgument), typeof(string), arg);
        }
        public QDBusArgument Write(QDBusVariant arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<?", "operator<<(const QDBusVariant&)", typeof(QDBusArgument), typeof(QDBusVariant), arg);
        }
        public QDBusArgument Write(QDBusObjectPath arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(const QDBusObjectPath&)", typeof(QDBusArgument), typeof(QDBusObjectPath), arg);
        }
        public QDBusArgument Write(QDBusSignature arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<$", "operator<<(const QDBusSignature&)", typeof(QDBusArgument), typeof(QDBusSignature), arg);
        }
        public QDBusArgument Write(List<string> arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<?", "operator<<(const QStringList&)", typeof(QDBusArgument), typeof(List<string>), arg);
        }
        public QDBusArgument Write(QByteArray arg) {
            return (QDBusArgument) interceptor.Invoke("operator<<#", "operator<<(const QByteArray&)", typeof(QDBusArgument), typeof(QByteArray), arg);
        }
        public void BeginStructure() {
            interceptor.Invoke("beginStructure", "beginStructure()", typeof(void));
        }
        public void EndStructure() {
            interceptor.Invoke("endStructure", "endStructure()", typeof(void));
        }
        public void BeginArray(int elementMetaTypeId) {
            interceptor.Invoke("beginArray$", "beginArray(int)", typeof(void), typeof(int), elementMetaTypeId);
        }
        public void EndArray() {
            interceptor.Invoke("endArray", "endArray()", typeof(void));
        }
        public void BeginMap(int keyMetaTypeId, int valueMetaTypeId) {
            interceptor.Invoke("beginMap$$", "beginMap(int, int)", typeof(void), typeof(int), keyMetaTypeId, typeof(int), valueMetaTypeId);
        }
        public void EndMap() {
            interceptor.Invoke("endMap", "endMap()", typeof(void));
        }
        public void BeginMapEntry() {
            interceptor.Invoke("beginMapEntry", "beginMapEntry()", typeof(void));
        }
        public void EndMapEntry() {
            interceptor.Invoke("endMapEntry", "endMapEntry()", typeof(void));
        }
        public void AppendVariant(QVariant v) {
            interceptor.Invoke("appendVariant#", "appendVariant(const QVariant&)", typeof(void), typeof(QVariant), v);
        }
        public string CurrentSignature() {
            return (string) interceptor.Invoke("currentSignature", "currentSignature() const", typeof(string));
        }
        public QDBusArgument.ElementType CurrentType() {
            return (QDBusArgument.ElementType) interceptor.Invoke("currentType", "currentType() const", typeof(QDBusArgument.ElementType));
        }
        public QDBusArgument Read(Pointer<byte> arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>$", "operator>>(uchar&) const", typeof(QDBusArgument), typeof(Pointer<byte>), arg);
        }
        public QDBusArgument Read(bool arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>$", "operator>>(bool&) const", typeof(QDBusArgument), typeof(bool), arg);
        }
        public QDBusArgument Read(ref short arg) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_short = arg;
            interceptor.Invoke("operator>>$", "operator>>(short&) const", stack);
            arg = stack[1].s_short;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).SynchronizedFree();
#endif
            return (QDBusArgument) returnValue;
        }
        public QDBusArgument Read(ref int arg) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_int = arg;
            interceptor.Invoke("operator>>$", "operator>>(int&) const", stack);
            arg = stack[1].s_int;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).SynchronizedFree();
#endif
            return (QDBusArgument) returnValue;
        }
        public QDBusArgument Read(uint arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>$", "operator>>(uint&) const", typeof(QDBusArgument), typeof(uint), arg);
        }
        public QDBusArgument Read(ref double arg) {
            StackItem[] stack = new StackItem[2];
            stack[1].s_double = arg;
            interceptor.Invoke("operator>>$", "operator>>(double&) const", stack);
            arg = stack[1].s_double;
            object returnValue = ((GCHandle) stack[0].s_class).Target;
#if DEBUG
            DebugGCHandle.Free((GCHandle) stack[0].s_class);
#else
            ((GCHandle) stack[0].s_class).SynchronizedFree();
#endif
            return (QDBusArgument) returnValue;
        }
        public QDBusArgument Read(StringBuilder arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>$", "operator>>(QString&) const", typeof(QDBusArgument), typeof(StringBuilder), arg);
        }
        public QDBusArgument Read(QDBusVariant arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>?", "operator>>(QDBusVariant&) const", typeof(QDBusArgument), typeof(QDBusVariant), arg);
        }
        public QDBusArgument Read(QDBusObjectPath arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>$", "operator>>(QDBusObjectPath&) const", typeof(QDBusArgument), typeof(QDBusObjectPath), arg);
        }
        public QDBusArgument Read(QDBusSignature arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>$", "operator>>(QDBusSignature&) const", typeof(QDBusArgument), typeof(QDBusSignature), arg);
        }
        public QDBusArgument Read(List<string> arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>?", "operator>>(QStringList&) const", typeof(QDBusArgument), typeof(List<string>), arg);
        }
        public QDBusArgument Read(QByteArray arg) {
            return (QDBusArgument) interceptor.Invoke("operator>>#", "operator>>(QByteArray&) const", typeof(QDBusArgument), typeof(QByteArray), arg);
        }
        public void BeginArray() {
            interceptor.Invoke("beginArray", "beginArray() const", typeof(void));
        }
        public void BeginMap() {
            interceptor.Invoke("beginMap", "beginMap() const", typeof(void));
        }
        public bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        public QVariant AsVariant() {
            return (QVariant) interceptor.Invoke("asVariant", "asVariant() const", typeof(QVariant));
        }
        ~QDBusArgument() {
            interceptor.Invoke("~QDBusArgument", "~QDBusArgument()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QDBusArgument", "~QDBusArgument()", typeof(void));
        }
    }
}