using System;
using System.Collections.Generic;
using System.Linq;

public enum ContentType {
    letter,
    number
}
public class Node : IComparable<Node> {
    public string id;
    public string content;
    public int index;
    public ContentType type;

    public int CompareTo(Node other) {
        if(this.type == ContentType.number && other.type == ContentType.number) {
            return this.index.CompareTo(other.index);
        }
        if(this.type == ContentType.letter && other.type == ContentType.letter) {
            if(this.content == other.content) {
                return String.CompareOrdinal(this.id, other.id); // string.CompareTo is not based on ascii order
            }
            return String.CompareOrdinal(this.content, other.content);
        }
        return this.type.CompareTo(other.type);
    }
}
public class LogSort {
    public string[] SortLog(string[] logs) {
        // sort + comparator
        // tc:O(nlogn); sc:O(n)
        if(logs == null || logs.Length == 0) {
            return new string[0];
        }
        Node[] nodeArr = new Node[logs.Length];
        string[] res = new string[logs.Length];
        for(int i = 0; i < logs.Length; i++) {
            Node node = new Node();
            int idx = logs[i].IndexOf(' ');
            node.index = i;
            node.id = logs[i].Substring(0, idx);
            node.content = logs[i].Substring(idx + 1);
            if(node.content[0] >= '0' && node.content[0] <= '9') {
                node.type = ContentType.number;
            }
            else {
                node.type = ContentType.letter;
            }
            nodeArr[i] = node;
        }
        Array.Sort(nodeArr);
        for(int i = 0; i < nodeArr.Length; i++) {
            res[i] = logs[nodeArr[i].index];
        }
        return res;
    }
}