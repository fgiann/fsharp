module LogLevels

let message (logLine: string): string =
    let startIdx = logLine.IndexOf(": ") + 2
    logLine.Substring(startIdx).Trim()

let logLevel(logLine: string): string =
    let startIdx = logLine.IndexOf("[") + 1
    let length = logLine.IndexOf("]") - startIdx
    logLine.Substring(startIdx, length).ToLower()

let reformat(logLine: string): string =
    $"{message logLine} ({logLevel logLine})"
