//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {

	using System;
	using System.Collections.Generic;

	[SmokeClass("QXmlStreamReader")]
	public class QXmlStreamReader : Object, IDisposable {
		protected SmokeInvocation interceptor = null;
		private IntPtr smokeObject;
		protected QXmlStreamReader(Type dummy) {}
		protected void CreateProxy() {
			interceptor = new SmokeInvocation(typeof(QXmlStreamReader), this);
		}
		public enum TokenType {
			NoToken = 0,
			Invalid = 1,
			StartDocument = 2,
			EndDocument = 3,
			StartElement = 4,
			EndElement = 5,
			Characters = 6,
			Comment = 7,
			DTD = 8,
			EntityReference = 9,
			ProcessingInstruction = 10,
		}
		public enum Error {
			NoError = 0,
			UnexpectedElementError = 1,
			CustomError = 2,
			NotWellFormedError = 3,
			PrematureEndOfDocumentError = 4,
		}
		[Q_PROPERTY("bool", "namespaceProcessing")]
		public bool NamespaceProcessing {
			get { return (bool) interceptor.Invoke("namespaceProcessing", "namespaceProcessing()", typeof(bool)); }
			set { interceptor.Invoke("setNamespaceProcessing$", "setNamespaceProcessing(bool)", typeof(void), typeof(bool), value); }
		}
		public QXmlStreamReader() : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamReader", "QXmlStreamReader()", typeof(void));
		}
		public QXmlStreamReader(QIODevice device) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamReader#", "QXmlStreamReader(QIODevice*)", typeof(void), typeof(QIODevice), device);
		}
		public QXmlStreamReader(QByteArray data) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamReader#", "QXmlStreamReader(const QByteArray&)", typeof(void), typeof(QByteArray), data);
		}
		public QXmlStreamReader(string data) : this((Type) null) {
			CreateProxy();
			interceptor.Invoke("QXmlStreamReader$", "QXmlStreamReader(const QString&)", typeof(void), typeof(string), data);
		}
		public void SetDevice(QIODevice device) {
			interceptor.Invoke("setDevice#", "setDevice(QIODevice*)", typeof(void), typeof(QIODevice), device);
		}
		public QIODevice Device() {
			return (QIODevice) interceptor.Invoke("device", "device() const", typeof(QIODevice));
		}
		public void AddData(QByteArray data) {
			interceptor.Invoke("addData#", "addData(const QByteArray&)", typeof(void), typeof(QByteArray), data);
		}
		public void AddData(string data) {
			interceptor.Invoke("addData$", "addData(const QString&)", typeof(void), typeof(string), data);
		}
		public void Clear() {
			interceptor.Invoke("clear", "clear()", typeof(void));
		}
		public bool AtEnd() {
			return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
		}
		public QXmlStreamReader.TokenType ReadNext() {
			return (QXmlStreamReader.TokenType) interceptor.Invoke("readNext", "readNext()", typeof(QXmlStreamReader.TokenType));
		}
		public QXmlStreamReader.TokenType tokenType() {
			return (QXmlStreamReader.TokenType) interceptor.Invoke("tokenType", "tokenType() const", typeof(QXmlStreamReader.TokenType));
		}
		public string TokenString() {
			return (string) interceptor.Invoke("tokenString", "tokenString() const", typeof(string));
		}
		public bool IsStartDocument() {
			return (bool) interceptor.Invoke("isStartDocument", "isStartDocument() const", typeof(bool));
		}
		public bool IsEndDocument() {
			return (bool) interceptor.Invoke("isEndDocument", "isEndDocument() const", typeof(bool));
		}
		public bool IsStartElement() {
			return (bool) interceptor.Invoke("isStartElement", "isStartElement() const", typeof(bool));
		}
		public bool IsEndElement() {
			return (bool) interceptor.Invoke("isEndElement", "isEndElement() const", typeof(bool));
		}
		public bool IsCharacters() {
			return (bool) interceptor.Invoke("isCharacters", "isCharacters() const", typeof(bool));
		}
		public bool IsWhitespace() {
			return (bool) interceptor.Invoke("isWhitespace", "isWhitespace() const", typeof(bool));
		}
		public bool IsCDATA() {
			return (bool) interceptor.Invoke("isCDATA", "isCDATA() const", typeof(bool));
		}
		public bool IsComment() {
			return (bool) interceptor.Invoke("isComment", "isComment() const", typeof(bool));
		}
		public bool IsDTD() {
			return (bool) interceptor.Invoke("isDTD", "isDTD() const", typeof(bool));
		}
		public bool IsEntityReference() {
			return (bool) interceptor.Invoke("isEntityReference", "isEntityReference() const", typeof(bool));
		}
		public bool IsProcessingInstruction() {
			return (bool) interceptor.Invoke("isProcessingInstruction", "isProcessingInstruction() const", typeof(bool));
		}
		public bool IsStandaloneDocument() {
			return (bool) interceptor.Invoke("isStandaloneDocument", "isStandaloneDocument() const", typeof(bool));
		}
		public long LineNumber() {
			return (long) interceptor.Invoke("lineNumber", "lineNumber() const", typeof(long));
		}
		public long ColumnNumber() {
			return (long) interceptor.Invoke("columnNumber", "columnNumber() const", typeof(long));
		}
		public long CharacterOffset() {
			return (long) interceptor.Invoke("characterOffset", "characterOffset() const", typeof(long));
		}
		public QXmlStreamAttributes Attributes() {
			return (QXmlStreamAttributes) interceptor.Invoke("attributes", "attributes() const", typeof(QXmlStreamAttributes));
		}
		public string ReadElementText() {
			return (string) interceptor.Invoke("readElementText", "readElementText()", typeof(string));
		}
		public string Name() {
			return (string) interceptor.Invoke("name", "name() const", typeof(string));
		}
		public string NamespaceUri() {
			return (string) interceptor.Invoke("namespaceUri", "namespaceUri() const", typeof(string));
		}
		public string QualifiedName() {
			return (string) interceptor.Invoke("qualifiedName", "qualifiedName() const", typeof(string));
		}
		public string ProcessingInstructionTarget() {
			return (string) interceptor.Invoke("processingInstructionTarget", "processingInstructionTarget() const", typeof(string));
		}
		public string ProcessingInstructionData() {
			return (string) interceptor.Invoke("processingInstructionData", "processingInstructionData() const", typeof(string));
		}
		public string Text() {
			return (string) interceptor.Invoke("text", "text() const", typeof(string));
		}
		public List<QXmlStreamNamespaceDeclaration> NamespaceDeclarations() {
			return (List<QXmlStreamNamespaceDeclaration>) interceptor.Invoke("namespaceDeclarations", "namespaceDeclarations() const", typeof(List<QXmlStreamNamespaceDeclaration>));
		}
		public List<QXmlStreamNotationDeclaration> NotationDeclarations() {
			return (List<QXmlStreamNotationDeclaration>) interceptor.Invoke("notationDeclarations", "notationDeclarations() const", typeof(List<QXmlStreamNotationDeclaration>));
		}
		public List<QXmlStreamEntityDeclaration> EntityDeclarations() {
			return (List<QXmlStreamEntityDeclaration>) interceptor.Invoke("entityDeclarations", "entityDeclarations() const", typeof(List<QXmlStreamEntityDeclaration>));
		}
		public void RaiseError(string message) {
			interceptor.Invoke("raiseError$", "raiseError(const QString&)", typeof(void), typeof(string), message);
		}
		public void RaiseError() {
			interceptor.Invoke("raiseError", "raiseError()", typeof(void));
		}
		public string ErrorString() {
			return (string) interceptor.Invoke("errorString", "errorString() const", typeof(string));
		}
		public QXmlStreamReader.Error error() {
			return (QXmlStreamReader.Error) interceptor.Invoke("error", "error() const", typeof(QXmlStreamReader.Error));
		}
		public bool HasError() {
			return (bool) interceptor.Invoke("hasError", "hasError() const", typeof(bool));
		}
		~QXmlStreamReader() {
			interceptor.Invoke("~QXmlStreamReader", "~QXmlStreamReader()", typeof(void));
		}
		public void Dispose() {
			interceptor.Invoke("~QXmlStreamReader", "~QXmlStreamReader()", typeof(void));
		}
	}
}
