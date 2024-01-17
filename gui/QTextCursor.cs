//Auto-generated by kalyptus. DO NOT EDIT.
namespace Qyoto {
    using System;
    [SmokeClass("QTextCursor")]
    public class QTextCursor : Object, IDisposable {
        protected SmokeInvocation interceptor = null;
        private IntPtr smokeObject;
        protected QTextCursor(Type dummy) {}
        protected void CreateProxy() {
            interceptor = new SmokeInvocation(typeof(QTextCursor), this);
        }
        private static SmokeInvocation staticInterceptor = null;
        static QTextCursor() {
            staticInterceptor = new SmokeInvocation(typeof(QTextCursor), null);
        }
        public enum MoveMode {
            MoveAnchor = 0,
            KeepAnchor = 1,
        }
        public enum MoveOperation {
            NoMove = 0,
            Start = 1,
            Up = 2,
            StartOfLine = 3,
            StartOfBlock = 4,
            StartOfWord = 5,
            PreviousBlock = 6,
            PreviousCharacter = 7,
            PreviousWord = 8,
            Left = 9,
            WordLeft = 10,
            End = 11,
            Down = 12,
            EndOfLine = 13,
            EndOfWord = 14,
            EndOfBlock = 15,
            NextBlock = 16,
            NextCharacter = 17,
            NextWord = 18,
            Right = 19,
            WordRight = 20,
            NextCell = 21,
            PreviousCell = 22,
            NextRow = 23,
            PreviousRow = 24,
        }
        public enum SelectionType {
            WordUnderCursor = 0,
            LineUnderCursor = 1,
            BlockUnderCursor = 2,
            Document = 3,
        }
        // QTextCursor* QTextCursor(QTextDocumentPrivate* arg1,int arg2); >>>> NOT CONVERTED
        // QTextCursor* QTextCursor(QTextCursorPrivate* arg1); >>>> NOT CONVERTED
        public QTextCursor() : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextCursor", "QTextCursor()", typeof(void));
        }
        public QTextCursor(QTextDocument document) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextCursor#", "QTextCursor(QTextDocument*)", typeof(void), typeof(QTextDocument), document);
        }
        public QTextCursor(QTextFrame frame) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextCursor#", "QTextCursor(QTextFrame*)", typeof(void), typeof(QTextFrame), frame);
        }
        public QTextCursor(QTextBlock block) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextCursor#", "QTextCursor(const QTextBlock&)", typeof(void), typeof(QTextBlock), block);
        }
        public QTextCursor(QTextCursor cursor) : this((Type) null) {
            CreateProxy();
            interceptor.Invoke("QTextCursor#", "QTextCursor(const QTextCursor&)", typeof(void), typeof(QTextCursor), cursor);
        }
        public bool IsNull() {
            return (bool) interceptor.Invoke("isNull", "isNull() const", typeof(bool));
        }
        public void SetPosition(int pos, QTextCursor.MoveMode mode) {
            interceptor.Invoke("setPosition$$", "setPosition(int, QTextCursor::MoveMode)", typeof(void), typeof(int), pos, typeof(QTextCursor.MoveMode), mode);
        }
        public void SetPosition(int pos) {
            interceptor.Invoke("setPosition$", "setPosition(int)", typeof(void), typeof(int), pos);
        }
        public int Position() {
            return (int) interceptor.Invoke("position", "position() const", typeof(int));
        }
        public int Anchor() {
            return (int) interceptor.Invoke("anchor", "anchor() const", typeof(int));
        }
        public void InsertText(string text) {
            interceptor.Invoke("insertText$", "insertText(const QString&)", typeof(void), typeof(string), text);
        }
        public void InsertText(string text, QTextCharFormat format) {
            interceptor.Invoke("insertText$#", "insertText(const QString&, const QTextCharFormat&)", typeof(void), typeof(string), text, typeof(QTextCharFormat), format);
        }
        public bool MovePosition(QTextCursor.MoveOperation op, QTextCursor.MoveMode arg2, int n) {
            return (bool) interceptor.Invoke("movePosition$$$", "movePosition(QTextCursor::MoveOperation, QTextCursor::MoveMode, int)", typeof(bool), typeof(QTextCursor.MoveOperation), op, typeof(QTextCursor.MoveMode), arg2, typeof(int), n);
        }
        public bool MovePosition(QTextCursor.MoveOperation op, QTextCursor.MoveMode arg2) {
            return (bool) interceptor.Invoke("movePosition$$", "movePosition(QTextCursor::MoveOperation, QTextCursor::MoveMode)", typeof(bool), typeof(QTextCursor.MoveOperation), op, typeof(QTextCursor.MoveMode), arg2);
        }
        public bool MovePosition(QTextCursor.MoveOperation op) {
            return (bool) interceptor.Invoke("movePosition$", "movePosition(QTextCursor::MoveOperation)", typeof(bool), typeof(QTextCursor.MoveOperation), op);
        }
        public bool VisualNavigation() {
            return (bool) interceptor.Invoke("visualNavigation", "visualNavigation() const", typeof(bool));
        }
        public void SetVisualNavigation(bool b) {
            interceptor.Invoke("setVisualNavigation$", "setVisualNavigation(bool)", typeof(void), typeof(bool), b);
        }
        public void DeleteChar() {
            interceptor.Invoke("deleteChar", "deleteChar()", typeof(void));
        }
        public void DeletePreviousChar() {
            interceptor.Invoke("deletePreviousChar", "deletePreviousChar()", typeof(void));
        }
        public void Select(QTextCursor.SelectionType selection) {
            interceptor.Invoke("select$", "select(QTextCursor::SelectionType)", typeof(void), typeof(QTextCursor.SelectionType), selection);
        }
        public bool HasSelection() {
            return (bool) interceptor.Invoke("hasSelection", "hasSelection() const", typeof(bool));
        }
        public bool HasComplexSelection() {
            return (bool) interceptor.Invoke("hasComplexSelection", "hasComplexSelection() const", typeof(bool));
        }
        public void RemoveSelectedText() {
            interceptor.Invoke("removeSelectedText", "removeSelectedText()", typeof(void));
        }
        public void ClearSelection() {
            interceptor.Invoke("clearSelection", "clearSelection()", typeof(void));
        }
        public int SelectionStart() {
            return (int) interceptor.Invoke("selectionStart", "selectionStart() const", typeof(int));
        }
        public int SelectionEnd() {
            return (int) interceptor.Invoke("selectionEnd", "selectionEnd() const", typeof(int));
        }
        public string SelectedText() {
            return (string) interceptor.Invoke("selectedText", "selectedText() const", typeof(string));
        }
        public QTextDocumentFragment Selection() {
            return (QTextDocumentFragment) interceptor.Invoke("selection", "selection() const", typeof(QTextDocumentFragment));
        }
        public void SelectedTableCells(ref int firstRow, ref int numRows, ref int firstColumn, ref int numColumns) {
            StackItem[] stack = new StackItem[5];
            stack[1].s_int = firstRow;
            stack[2].s_int = numRows;
            stack[3].s_int = firstColumn;
            stack[4].s_int = numColumns;
            interceptor.Invoke("selectedTableCells$$$$", "selectedTableCells(int*, int*, int*, int*) const", stack);
            firstRow = stack[1].s_int;
            numRows = stack[2].s_int;
            firstColumn = stack[3].s_int;
            numColumns = stack[4].s_int;
            return;
        }
        public QTextBlock Block() {
            return (QTextBlock) interceptor.Invoke("block", "block() const", typeof(QTextBlock));
        }
        public QTextCharFormat CharFormat() {
            return (QTextCharFormat) interceptor.Invoke("charFormat", "charFormat() const", typeof(QTextCharFormat));
        }
        public void SetCharFormat(QTextCharFormat format) {
            interceptor.Invoke("setCharFormat#", "setCharFormat(const QTextCharFormat&)", typeof(void), typeof(QTextCharFormat), format);
        }
        public void MergeCharFormat(QTextCharFormat modifier) {
            interceptor.Invoke("mergeCharFormat#", "mergeCharFormat(const QTextCharFormat&)", typeof(void), typeof(QTextCharFormat), modifier);
        }
        public QTextBlockFormat BlockFormat() {
            return (QTextBlockFormat) interceptor.Invoke("blockFormat", "blockFormat() const", typeof(QTextBlockFormat));
        }
        public void SetBlockFormat(QTextBlockFormat format) {
            interceptor.Invoke("setBlockFormat#", "setBlockFormat(const QTextBlockFormat&)", typeof(void), typeof(QTextBlockFormat), format);
        }
        public void MergeBlockFormat(QTextBlockFormat modifier) {
            interceptor.Invoke("mergeBlockFormat#", "mergeBlockFormat(const QTextBlockFormat&)", typeof(void), typeof(QTextBlockFormat), modifier);
        }
        public QTextCharFormat BlockCharFormat() {
            return (QTextCharFormat) interceptor.Invoke("blockCharFormat", "blockCharFormat() const", typeof(QTextCharFormat));
        }
        public void SetBlockCharFormat(QTextCharFormat format) {
            interceptor.Invoke("setBlockCharFormat#", "setBlockCharFormat(const QTextCharFormat&)", typeof(void), typeof(QTextCharFormat), format);
        }
        public void MergeBlockCharFormat(QTextCharFormat modifier) {
            interceptor.Invoke("mergeBlockCharFormat#", "mergeBlockCharFormat(const QTextCharFormat&)", typeof(void), typeof(QTextCharFormat), modifier);
        }
        public bool AtBlockStart() {
            return (bool) interceptor.Invoke("atBlockStart", "atBlockStart() const", typeof(bool));
        }
        public bool AtBlockEnd() {
            return (bool) interceptor.Invoke("atBlockEnd", "atBlockEnd() const", typeof(bool));
        }
        public bool AtStart() {
            return (bool) interceptor.Invoke("atStart", "atStart() const", typeof(bool));
        }
        public bool AtEnd() {
            return (bool) interceptor.Invoke("atEnd", "atEnd() const", typeof(bool));
        }
        public void InsertBlock() {
            interceptor.Invoke("insertBlock", "insertBlock()", typeof(void));
        }
        public void InsertBlock(QTextBlockFormat format) {
            interceptor.Invoke("insertBlock#", "insertBlock(const QTextBlockFormat&)", typeof(void), typeof(QTextBlockFormat), format);
        }
        public void InsertBlock(QTextBlockFormat format, QTextCharFormat charFormat) {
            interceptor.Invoke("insertBlock##", "insertBlock(const QTextBlockFormat&, const QTextCharFormat&)", typeof(void), typeof(QTextBlockFormat), format, typeof(QTextCharFormat), charFormat);
        }
        public QTextList InsertList(QTextListFormat format) {
            return (QTextList) interceptor.Invoke("insertList#", "insertList(const QTextListFormat&)", typeof(QTextList), typeof(QTextListFormat), format);
        }
        public QTextList InsertList(QTextListFormat.Style style) {
            return (QTextList) interceptor.Invoke("insertList$", "insertList(QTextListFormat::Style)", typeof(QTextList), typeof(QTextListFormat.Style), style);
        }
        public QTextList CreateList(QTextListFormat format) {
            return (QTextList) interceptor.Invoke("createList#", "createList(const QTextListFormat&)", typeof(QTextList), typeof(QTextListFormat), format);
        }
        public QTextList CreateList(QTextListFormat.Style style) {
            return (QTextList) interceptor.Invoke("createList$", "createList(QTextListFormat::Style)", typeof(QTextList), typeof(QTextListFormat.Style), style);
        }
        public QTextList CurrentList() {
            return (QTextList) interceptor.Invoke("currentList", "currentList() const", typeof(QTextList));
        }
        public QTextTable InsertTable(int rows, int cols, QTextTableFormat format) {
            return (QTextTable) interceptor.Invoke("insertTable$$#", "insertTable(int, int, const QTextTableFormat&)", typeof(QTextTable), typeof(int), rows, typeof(int), cols, typeof(QTextTableFormat), format);
        }
        public QTextTable InsertTable(int rows, int cols) {
            return (QTextTable) interceptor.Invoke("insertTable$$", "insertTable(int, int)", typeof(QTextTable), typeof(int), rows, typeof(int), cols);
        }
        public QTextTable CurrentTable() {
            return (QTextTable) interceptor.Invoke("currentTable", "currentTable() const", typeof(QTextTable));
        }
        public QTextFrame InsertFrame(QTextFrameFormat format) {
            return (QTextFrame) interceptor.Invoke("insertFrame#", "insertFrame(const QTextFrameFormat&)", typeof(QTextFrame), typeof(QTextFrameFormat), format);
        }
        public QTextFrame CurrentFrame() {
            return (QTextFrame) interceptor.Invoke("currentFrame", "currentFrame() const", typeof(QTextFrame));
        }
        public void InsertFragment(QTextDocumentFragment fragment) {
            interceptor.Invoke("insertFragment#", "insertFragment(const QTextDocumentFragment&)", typeof(void), typeof(QTextDocumentFragment), fragment);
        }
        public void InsertHtml(string html) {
            interceptor.Invoke("insertHtml$", "insertHtml(const QString&)", typeof(void), typeof(string), html);
        }
        public void InsertImage(QTextImageFormat format, QTextFrameFormat.Position alignment) {
            interceptor.Invoke("insertImage#$", "insertImage(const QTextImageFormat&, QTextFrameFormat::Position)", typeof(void), typeof(QTextImageFormat), format, typeof(QTextFrameFormat.Position), alignment);
        }
        public void InsertImage(QTextImageFormat format) {
            interceptor.Invoke("insertImage#", "insertImage(const QTextImageFormat&)", typeof(void), typeof(QTextImageFormat), format);
        }
        public void InsertImage(string name) {
            interceptor.Invoke("insertImage$", "insertImage(const QString&)", typeof(void), typeof(string), name);
        }
        public void InsertImage(QImage image, string name) {
            interceptor.Invoke("insertImage#$", "insertImage(const QImage&, const QString&)", typeof(void), typeof(QImage), image, typeof(string), name);
        }
        public void InsertImage(QImage image) {
            interceptor.Invoke("insertImage#", "insertImage(const QImage&)", typeof(void), typeof(QImage), image);
        }
        public void BeginEditBlock() {
            interceptor.Invoke("beginEditBlock", "beginEditBlock()", typeof(void));
        }
        public void JoinPreviousEditBlock() {
            interceptor.Invoke("joinPreviousEditBlock", "joinPreviousEditBlock()", typeof(void));
        }
        public void EndEditBlock() {
            interceptor.Invoke("endEditBlock", "endEditBlock()", typeof(void));
        }
        public override bool Equals(object o) {
            if (!(o is QTextCursor)) { return false; }
            return this == (QTextCursor) o;
        }
        public override int GetHashCode() {
            return interceptor.GetHashCode();
        }
        public bool IsCopyOf(QTextCursor other) {
            return (bool) interceptor.Invoke("isCopyOf#", "isCopyOf(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), other);
        }
        public int BlockNumber() {
            return (int) interceptor.Invoke("blockNumber", "blockNumber() const", typeof(int));
        }
        public int ColumnNumber() {
            return (int) interceptor.Invoke("columnNumber", "columnNumber() const", typeof(int));
        }
        public QTextDocument Document() {
            return (QTextDocument) interceptor.Invoke("document", "document() const", typeof(QTextDocument));
        }
        ~QTextCursor() {
            interceptor.Invoke("~QTextCursor", "~QTextCursor()", typeof(void));
        }
        public void Dispose() {
            interceptor.Invoke("~QTextCursor", "~QTextCursor()", typeof(void));
        }
        public static bool operator<(QTextCursor lhs, QTextCursor rhs) {
            return (bool) staticInterceptor.Invoke("operator<#", "operator<(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), lhs, typeof(QTextCursor), rhs);
        }
        public static bool operator<=(QTextCursor lhs, QTextCursor rhs) {
            return (bool) staticInterceptor.Invoke("operator<=#", "operator<=(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), lhs, typeof(QTextCursor), rhs);
        }
        public static bool operator==(QTextCursor lhs, QTextCursor rhs) {
            return (bool) staticInterceptor.Invoke("operator==#", "operator==(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), lhs, typeof(QTextCursor), rhs);
        }
        public static bool operator!=(QTextCursor lhs, QTextCursor rhs) {
            return !(bool) staticInterceptor.Invoke("operator==#", "operator==(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), lhs, typeof(QTextCursor), rhs);
        }
        public static bool operator>=(QTextCursor lhs, QTextCursor rhs) {
            return (bool) staticInterceptor.Invoke("operator>=#", "operator>=(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), lhs, typeof(QTextCursor), rhs);
        }
        public static bool operator>(QTextCursor lhs, QTextCursor rhs) {
            return (bool) staticInterceptor.Invoke("operator>#", "operator>(const QTextCursor&) const", typeof(bool), typeof(QTextCursor), lhs, typeof(QTextCursor), rhs);
        }
    }
}
