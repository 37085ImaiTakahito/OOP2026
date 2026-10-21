namespace TextFileProcessor;
public abstract class TextProcesser {
    public static void Run<T>(String fileName) where T : TextProcesser, new() {
        var self = new T();
        self.Process(fileName);
    }

    private void Process(string fileName) {
        Initialize(fileName);
        var lines = File.ReadLines(fileName);
        foreach(var line in lines) {
            Execute(line);
        }
        Terminate();
    }

    protected virtual void Initialize(string fname) { }
    protected virtual void Execute(string line) { }
    protected virtual void Terminate() { }
}
