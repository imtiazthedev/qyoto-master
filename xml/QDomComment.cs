//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QDomComment")]
    public class QDomComment : QDomCharacterData, IDisposable {
        protected QDomComment(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QDomComment), this);
        }
        public QDomComment() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDomComment", "QDomComment()", typeof(void));
        }
        public QDomComment(QDomComment x) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QDomComment#", "QDomComment(const QDomComment&)", typeof(void), typeof(QDomComment), x);
        }
        public new QDomNode.NodeType NodeType() {
            return (QDomNode.NodeType) interceptor.Invoke("nodeType", "nodeType() const", typeof(QDomNode.NodeType));
        }
        ~QDomComment() {
            interceptor.Invoke("~QDomComment", "~QDomComment()", typeof(void));
        }
        public new void Dispose() {
            interceptor.Invoke("~QDomComment", "~QDomComment()", typeof(void));
        }
    }
}