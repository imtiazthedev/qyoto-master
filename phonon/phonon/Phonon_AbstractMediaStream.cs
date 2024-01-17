//Auto-generated by kalyptus. DO NOT EDIT.
namespace Phonon {
    using Phonon;
    using System;
    using Qyoto;
    /// <remarks> \class AbstractMediaStream abstractmediastream.h Phonon/AbstractMediaStream
    ///  \brief Base class for custom media data streams.
    ///  Implement this class to provide a custom data stream to the backend. The class supports both, the
    ///  push and the pull model.
    ///  Push:
    ///  <pre>
    ///  PushStream.PushStream(QObject parent), m_timer(new QTimer(this))
    ///  {
    ///    setStreamSize(getMediaStreamSize());
    ///    connect(m_timer, SIGNAL("timeout()"), SLOT("moreData()"));
    ///    m_timer.SetInterval(0);
    ///  }
    ///  void PushStream.MoreData()
    ///  {
    ///    const QByteArray data = getMediaData();
    ///    if (data.isEmpty()) {
    ///      endOfData();
    ///    } else {
    ///      writeData(data);
    ///    }
    ///  }
    ///  void PushStream.NeedData()
    ///  {
    ///    m_timer.Start();
    ///    moreData();
    ///  }
    ///  void PushStream.EnoughData()
    ///  {
    ///    m_timer.Stop();
    ///  }
    ///  </pre>
    ///  Pull:
    ///  <pre>
    ///  PullStream.PullStream(QObject parent)
    ///  {
    ///    setStreamSize(getMediaStreamSize());
    ///  }
    ///  void PullStream.NeedData()
    ///  {
    ///    const QByteArray data = getMediaData();
    ///    if (data.isEmpty()) {
    ///      endOfData();
    ///    } else {
    ///      writeData(data);
    ///    }
    ///  }
    ///  </pre>
    ///  \ingroup Playback
    ///  \author Matthias Kretz <kretz@kde.org>
    ///  </remarks>        <short>   \class AbstractMediaStream abstractmediastream.</short>
    [SmokeClass("Phonon::AbstractMediaStream")]
    public abstract class AbstractMediaStream : QObject {
        protected AbstractMediaStream(Type dummy) : base((Type) null) {}
        protected new void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(AbstractMediaStream), this);
        }
        // Phonon::AbstractMediaStream* AbstractMediaStream(Phonon::AbstractMediaStreamPrivate& arg1,QObject* arg2); >>>> NOT CONVERTED
        /// <remarks>
        ///  Constructs an AbstractMediaStream object with a <pre>parent</pre>.
        ///          </remarks>        <short>    Constructs an AbstractMediaStream object with a \p parent.</short>
        public AbstractMediaStream(QObject parent) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractMediaStream#", "AbstractMediaStream(QObject*)", typeof(void), typeof(QObject), parent);
        }
        public AbstractMediaStream() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("AbstractMediaStream", "AbstractMediaStream()", typeof(void));
        }
        /// <remarks>
        ///  Returns the stream size that was set with \ref setStreamSize.
        ///  A negative value means that the length of the stream cannot be known.
        ///  Defaults to <code>0</code>.
        ///          </remarks>        <short>    Returns the stream size that was set with \ref setStreamSize.</short>
        protected long StreamSize() {
            return (long) interceptor.Invoke("streamSize", "streamSize() const", typeof(long));
        }
        /// <remarks>
        ///  Sets the size of the stream in number of bytes.
        ///  A negative value means that the length of the stream cannot be known.
        ///  Defaults to 0.
        ///  This function has to be called. A backend will not call \ref needData() until the
        ///  stream size is set.
        ///          </remarks>        <short>    Sets the size of the stream in number of bytes.</short>
        protected void SetStreamSize(long arg1) {
            interceptor.Invoke("setStreamSize$", "setStreamSize(qint64)", typeof(void), typeof(long), arg1);
        }
        /// <remarks>
        ///  Returns whether your data stream is set as seekable.
        ///  Defaults to <code>false</code>.
        ///          </remarks>        <short>    Returns whether your data stream is set as seekable.</short>
        protected bool StreamSeekable() {
            return (bool) interceptor.Invoke("streamSeekable", "streamSeekable() const", typeof(bool));
        }
        /// <remarks>
        ///  Sets whether your data stream is seekable.
        ///  Defaults to <code>false</code>.
        ///  If you set this to <code>true</code> you have to implement the \ref seekStream function.
        ///          </remarks>        <short>    Sets whether your data stream is seekable.</short>
        protected void SetStreamSeekable(bool arg1) {
            interceptor.Invoke("setStreamSeekable$", "setStreamSeekable(bool)", typeof(void), typeof(bool), arg1);
        }
        /// <remarks>
        ///  Sends the media <pre>data</pre> to the backend for decoding.
        ///  \warning Don't call this function before the first needData() is emitted.
        ///          </remarks>        <short>    Sends the media \p data to the backend for decoding.</short>
        protected void WriteData(QByteArray data) {
            interceptor.Invoke("writeData#", "writeData(const QByteArray&)", typeof(void), typeof(QByteArray), data);
        }
        /// <remarks>
        ///  Tells the backend that the media data stream is at its end.
        ///  \warning Don't call this function before the first needData() is emitted.
        ///          </remarks>        <short>    Tells the backend that the media data stream is at its end.</short>
        protected void EndOfData() {
            interceptor.Invoke("endOfData", "endOfData()", typeof(void));
        }
        /// <remarks>
        ///  If an I/O error occurs you should call this function to make MediaObject go into
        ///  ErrorState.
        ///  \see MediaObject.ErrorType()
        ///  \see MediaObject.ErrorString()
        ///          </remarks>        <short>    If an I/O error occurs you should call this function to make MediaObject go into  ErrorState.</short>
        protected void Error(Phonon.ErrorType errorType, string errorString) {
            interceptor.Invoke("error$$", "error(Phonon::ErrorType, const QString&)", typeof(void), typeof(Phonon.ErrorType), errorType, typeof(string), errorString);
        }
        /// <remarks>
        ///  Reimplement this function to reset the stream. Subsequent calls to writeData should start
        ///  from the first position of the data unless a seek is requested.
        ///  The function is necessary for the case where a non-seekable MediaStream is
        ///  played more than once. For a seekable stream the implementation can simply call
        ///  <pre>
        ///  seekStream(0);
        ///  </pre>.
        ///          </remarks>        <short>    Reimplement this function to reset the stream.</short>
        [SmokeMethod("reset()")]
        protected abstract void Reset();
        /// <remarks>
        ///  Reimplement this function to be notified when the backend needs data.
        ///  When this function is called you should try to call writeData or endOfData before
        ///  returning.
        ///          </remarks>        <short>    Reimplement this function to be notified when the backend needs data.</short>
        [SmokeMethod("needData()")]
        protected abstract void NeedData();
        /// <remarks>
        ///  Reimplement this function to be notified when the backend has enough data and your stream
        ///  object may take a break. This method is important for pushing data to the backend in
        ///  order to not fill the backend buffer unnecessarily.
        ///          </remarks>        <short>    Reimplement this function to be notified when the backend has enough data and your stream  object may take a break.</short>
        [SmokeMethod("enoughData()")]
        protected virtual void EnoughData() {
            interceptor.Invoke("enoughData", "enoughData()", typeof(void));
        }
        /// <remarks>
        ///  Reimplement this function if your stream is seekable.
        ///  When this function is called the next call to writeData has to be at the requested <pre>offset</pre>.
        ///  \warning Do not call the parent implementation.
        ///          </remarks>        <short>    Reimplement this function if your stream is seekable.</short>
        [SmokeMethod("seekStream(qint64)")]
        protected virtual void SeekStream(long offset) {
            interceptor.Invoke("seekStream$", "seekStream(qint64)", typeof(void), typeof(long), offset);
        }
        protected new IAbstractMediaStreamSignals Emit {
            get { return (IAbstractMediaStreamSignals) Q_EMIT; }
        }
    }

    public interface IAbstractMediaStreamSignals : IQObjectSignals {
    }
}
