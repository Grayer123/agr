class Stack {
public:
    /*
     * @param x: An integer
     * @return: nothing
     */
    void push(int x) {
        vec.push_back(x);
    }

    /*
     * @return: nothing
     */
    void pop() {
        if(vec.size() > 0) {
            vec.pop_back();
        }
    }

    /*
     * @return: An integer
     */
    int top() {
        return vec[vec.size() - 1];
    }

    /*
     * @return: True if the stack is empty
     */
    bool isEmpty() {
        return vec.size() == 0;
    }

private:
    vector<int> vec;
};