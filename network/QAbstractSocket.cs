//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    /// <remarks> See <see cref="IQAbstractSocketSignals"></see> for signals emitted by QAbstractSocket
    /// </remarks>
    [SmokeClass("QAbstractSocket")]
    public abstract class QAbstractSocket : QIODevice {
        protected QAbstractSocket(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QAbstractSocket), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QAbstractSocket() {
            staticInterceptor = new SmokeInvocation(typeof(QAbstractSocket), null);
        }
        public enum SocketType {
            TcpSocket = 0,
            UdpSocket = 1,
            UnknownSocketType = -1,
        }
        public enum NetworkLayerProtocol {
            IPv4Protocol = 0,
            IPv6Protocol = 1,
            UnknownNetworkLayerProtocol = -1,
        }
        public enum SocketError {
            ConnectionRefusedError = 0,
            RemoteHostClosedError = 1,
            HostNotFoundError = 2,
            SocketAccessError = 3,
            SocketResourceError = 4,
            SocketTimeoutError = 5,
            DatagramTooLargeError = 6,
            NetworkError = 7,
            AddressInUseError = 8,
            SocketAddressNotAvailableError = 9,
            UnsupportedSocketOperationError = 10,
            UnfinishedSocketOperationError = 11,
            ProxyAuthenticationRequiredError = 12,
            SslHandshakeFailedError = 13,
            ProxyConnectionRefusedError = 14,
            ProxyConnectionClosedError = 15,
            ProxyConnectionTimeoutError = 16,
            ProxyNotFoundError = 17,
            ProxyProtocolError = 18,
            UnknownSocketError = -1,
        }
        public enum SocketState {
            UnconnectedState = 0,
            HostLookupState = 1,
            ConnectingState = 2,
            ConnectedState = 3,
            BoundState = 4,
            ListeningState = 5,
            ClosingState = 6,
        }
        // QAbstractSocket* QAbstractSocket(QAbstractSocket::SocketType arg1,QAbstractSocketPrivate& arg2,QObject* arg3); >>>> NOT CONVERTED
        // QAbstractSocket* QAbstractSocket(QAbstractSocket::SocketType arg1,QAbstractSocketPrivate& arg2); >>>> NOT CONVERTED
        public QAbstractSocket(QAbstractSocket.SocketType socketType, QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QAbstractSocket$#", "QAbstractSocket(QAbstractSocket::SocketType, QObject*)", typeof(void), typeof(QAbstractSocket.SocketType), socketType, typeof(QObject), parent);
        }
        public void ConnectToHost(string hostName, ushort port, uint mode) {
            interceptor.Invoke("connectToHost$$$", "connectToHost(const QString&, unsigned short, QIODevice::OpenMode)", typeof(void), typeof(string), hostName, typeof(ushort), port, typeof(uint), mode);
        }
        public void ConnectToHost(string hostName, ushort port) {
            interceptor.Invoke("connectToHost$$", "connectToHost(const QString&, unsigned short)", typeof(void), typeof(string), hostName, typeof(ushort), port);
        }
        public void ConnectToHost(QHostAddress address, ushort port, uint mode) {
            interceptor.Invoke("connectToHost#$$", "connectToHost(const QHostAddress&, unsigned short, QIODevice::OpenMode)", typeof(void), typeof(QHostAddress), address, typeof(ushort), port, typeof(uint), mode);
        }
        public void ConnectToHost(QHostAddress address, ushort port) {
            interceptor.Invoke("connectToHost#$", "connectToHost(const QHostAddress&, unsigned short)", typeof(void), typeof(QHostAddress), address, typeof(ushort), port);
        }
        public void DisconnectFromHost() {
            interceptor.Invoke("disconnectFromHost", "disconnectFromHost()", typeof(void));
        }
        public bool IsValid() {
            return (bool) interceptor.Invoke("isValid", "isValid() const", typeof(bool));
        }
        [SmokeMethod("bytesAvailable() const")]
        public override long BytesAvailable() {
            return (long) interceptor.Invoke("bytesAvailable", "bytesAvailable() const", typeof(long));
        }
        [SmokeMethod("bytesToWrite() const")]
        public override long BytesToWrite() {
            return (long) interceptor.Invoke("bytesToWrite", "bytesToWrite() const", typeof(long));
        }
        [SmokeMethod("canReadLine() const")]
        public override bool CanReadLine() {
            return (bool) interceptor.Invoke("canReadLine", "canReadLine() const", typeof(bool));
        }
        public ushort LocalPort() {
            return (ushort) interceptor.Invoke("localPort", "localPort() const", typeof(ushort));
        }
        public QHostAddress LocalAddress() {
            return (QHostAddress) interceptor.Invoke("localAddress", "localAddress() const", typeof(QHostAddress));
        }
        public ushort PeerPort() {
            return (ushort) interceptor.Invoke("peerPort", "peerPort() const", typeof(ushort));
        }
        public QHostAddress PeerAddress() {
            return (QHostAddress) interceptor.Invoke("peerAddress", "peerAddress() const", typeof(QHostAddress));
        }
        public string PeerName() {
            return (string) interceptor.Invoke("peerName", "peerName() const", typeof(string));
        }
        public long ReadBufferSize() {
            return (long) interceptor.Invoke("readBufferSize", "readBufferSize() const", typeof(long));
        }
        public void SetReadBufferSize(long size) {
            interceptor.Invoke("setReadBufferSize$", "setReadBufferSize(qint64)", typeof(void), typeof(long), size);
        }
        public void Abort() {
            interceptor.Invoke("abort", "abort()", typeof(void));
        }
        public int SocketDescriptor() {
            return (int) interceptor.Invoke("socketDescriptor", "socketDescriptor() const", typeof(int));
        }
        public bool SetSocketDescriptor(int socketDescriptor, QAbstractSocket.SocketState state, uint openMode) {
            return (bool) interceptor.Invoke("setSocketDescriptor$$$", "setSocketDescriptor(int, QAbstractSocket::SocketState, QIODevice::OpenMode)", typeof(bool), typeof(int), socketDescriptor, typeof(QAbstractSocket.SocketState), state, typeof(uint), openMode);
        }
        public bool SetSocketDescriptor(int socketDescriptor, QAbstractSocket.SocketState state) {
            return (bool) interceptor.Invoke("setSocketDescriptor$$", "setSocketDescriptor(int, QAbstractSocket::SocketState)", typeof(bool), typeof(int), socketDescriptor, typeof(QAbstractSocket.SocketState), state);
        }
        public bool SetSocketDescriptor(int socketDescriptor) {
            return (bool) interceptor.Invoke("setSocketDescriptor$", "setSocketDescriptor(int)", typeof(bool), typeof(int), socketDescriptor);
        }
        public QAbstractSocket.SocketType socketType() {
            return (QAbstractSocket.SocketType) interceptor.Invoke("socketType", "socketType() const", typeof(QAbstractSocket.SocketType));
        }
        public QAbstractSocket.SocketState State() {
            return (QAbstractSocket.SocketState) interceptor.Invoke("state", "state() const", typeof(QAbstractSocket.SocketState));
        }
        public QAbstractSocket.SocketError Error() {
            return (QAbstractSocket.SocketError) interceptor.Invoke("error", "error() const", typeof(QAbstractSocket.SocketError));
        }
        [SmokeMethod("close()")]
        public override void Close() {
            interceptor.Invoke("close", "close()", typeof(void));
        }
        [SmokeMethod("isSequential() const")]
        public override bool IsSequential() {
            return (bool) interceptor.Invoke("isSequential", "isSequential() const", typeof(bool));
        }
        [SmokeMethod("atEnd() const")]
        public override bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        public bool Flush() {
            return (bool) interceptor.Invoke("flush", "flush()", typeof(bool));
        }
        public bool WaitForConnected(int msecs) {
            return (bool) interceptor.Invoke("waitForConnected$", "waitForConnected(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForConnected() {
            return (bool) interceptor.Invoke("waitForConnected", "waitForConnected()", typeof(bool));
        }
        [SmokeMethod("waitForReadyRead(int)")]
        public override bool WaitForReadyRead(int msecs) {
            return (bool) interceptor.Invoke("waitForReadyRead$", "waitForReadyRead(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForReadyRead() {
            return (bool) interceptor.Invoke("waitForReadyRead", "waitForReadyRead()", typeof(bool));
        }
        [SmokeMethod("waitForBytesWritten(int)")]
        public override bool WaitForBytesWritten(int msecs) {
            return (bool) interceptor.Invoke("waitForBytesWritten$", "waitForBytesWritten(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForBytesWritten() {
            return (bool) interceptor.Invoke("waitForBytesWritten", "waitForBytesWritten()", typeof(bool));
        }
        public bool WaitForDisconnected(int msecs) {
            return (bool) interceptor.Invoke("waitForDisconnected$", "waitForDisconnected(int)", typeof(bool), typeof(int), msecs);
        }
        public bool WaitForDisconnected() {
            return (bool) interceptor.Invoke("waitForDisconnected", "waitForDisconnected()", typeof(bool));
        }
        public void SetProxy(QNetworkProxy networkProxy) {
            interceptor.Invoke("setProxy#", "setProxy(const QNetworkProxy&)", typeof(void), typeof(QNetworkProxy), networkProxy);
        }
        public QNetworkProxy Proxy() {
            return (QNetworkProxy) interceptor.Invoke("proxy", "proxy() const", typeof(QNetworkProxy));
        }
        [SmokeMethod("readData(char*, qint64)")]
        protected override long ReadData(Pointer<sbyte> data, long maxlen) {
            return (long) interceptor.Invoke("readData$$", "readData(char*, qint64)", typeof(long), typeof(Pointer<sbyte>), data, typeof(long), maxlen);
        }
        [SmokeMethod("readLineData(char*, qint64)")]
        protected override long ReadLineData(Pointer<sbyte> data, long maxlen) {
            return (long) interceptor.Invoke("readLineData$$", "readLineData(char*, qint64)", typeof(long), typeof(Pointer<sbyte>), data, typeof(long), maxlen);
        }
        [SmokeMethod("writeData(const char*, qint64)")]
        protected override long WriteData(string data, long len) {
            return (long) interceptor.Invoke("writeData$$", "writeData(const char*, qint64)", typeof(long), typeof(string), data, typeof(long), len);
        }
        protected void SetSocketState(QAbstractSocket.SocketState state) {
            interceptor.Invoke("setSocketState$", "setSocketState(QAbstractSocket::SocketState)", typeof(void), typeof(QAbstractSocket.SocketState), state);
        }
        protected void SetSocketError(QAbstractSocket.SocketError socketError) {
            interceptor.Invoke("setSocketError$", "setSocketError(QAbstractSocket::SocketError)", typeof(void), typeof(QAbstractSocket.SocketError), socketError);
        }
        protected void SetLocalPort(ushort port) {
            interceptor.Invoke("setLocalPort$", "setLocalPort(unsigned short)", typeof(void), typeof(ushort), port);
        }
        protected void SetLocalAddress(QHostAddress address) {
            interceptor.Invoke("setLocalAddress#", "setLocalAddress(const QHostAddress&)", typeof(void), typeof(QHostAddress), address);
        }
        protected void SetPeerPort(ushort port) {
            interceptor.Invoke("setPeerPort$", "setPeerPort(unsigned short)", typeof(void), typeof(ushort), port);
        }
        protected void SetPeerAddress(QHostAddress address) {
            interceptor.Invoke("setPeerAddress#", "setPeerAddress(const QHostAddress&)", typeof(void), typeof(QHostAddress), address);
        }
        protected void SetPeerName(string name) {
            interceptor.Invoke("setPeerName$", "setPeerName(const QString&)", typeof(void), typeof(string), name);
        }
        [Q_SLOT("void connectToHostImplementation(QString, quint16, OpenMode)")]
        protected void ConnectToHostImplementation(string hostName, ushort port, uint mode) {
            interceptor.Invoke("connectToHostImplementation$$$", "connectToHostImplementation(const QString&, unsigned short, QIODevice::OpenMode)", typeof(void), typeof(string), hostName, typeof(ushort), port, typeof(uint), mode);
        }
        [Q_SLOT("void connectToHostImplementation(QString, quint16)")]
        protected void ConnectToHostImplementation(string hostName, ushort port) {
            interceptor.Invoke("connectToHostImplementation$$", "connectToHostImplementation(const QString&, unsigned short)", typeof(void), typeof(string), hostName, typeof(ushort), port);
        }
        [Q_SLOT("void disconnectFromHostImplementation()")]
        protected void DisconnectFromHostImplementation() {
            interceptor.Invoke("disconnectFromHostImplementation", "disconnectFromHostImplementation()", typeof(void));
        }
        public static new string Tr(string s, string c) {
            return (string) staticInterceptor.Invoke("tr$$", "tr(const char*, const char*)", typeof(string), typeof(string), s, typeof(string), c);
        }
        public static new string Tr(string s) {
            return (string) staticInterceptor.Invoke("tr$", "tr(const char*)", typeof(string), typeof(string), s);
        }
        protected new IQAbstractSocketSignals Emit {
            get { return (IQAbstractSocketSignals) Q_EMIT; }
        }
    }

    public interface IQAbstractSocketSignals : IQIODeviceSignals {
        [Q_SIGNAL("void hostFound()")]
        void HostFound();
        [Q_SIGNAL("void connected()")]
        void Connected();
        [Q_SIGNAL("void disconnected()")]
        void Disconnected();
        [Q_SIGNAL("void stateChanged(QAbstractSocket::SocketState)")]
        void StateChanged(QAbstractSocket.SocketState arg1);
        [Q_SIGNAL("void error(QAbstractSocket::SocketError)")]
        void Error(QAbstractSocket.SocketError arg1);
        [Q_SIGNAL("void proxyAuthenticationRequired(QNetworkProxy, QAuthenticator*)")]
        void ProxyAuthenticationRequired(QNetworkProxy proxy, QAuthenticator authenticator);
    }
}
