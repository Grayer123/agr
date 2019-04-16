class LoadBalancer {
public:
    LoadBalancer() {
        // do intialization if necessary
        srand(time(NULL)); // set the seed
    }

    /*
     * @param server_id: add a new server to the cluster
     * @return: nothing
     */
    void add(int server_id) {
        if(dict.find(server_id) != dict.end()) {
            return;
        }
        int index = servers.size();
        dict[server_id] = index;
        servers.push_back(server_id);
    }

    /*
     * @param server_id: server_id remove a bad server from the cluster
     * @return: nothing
     */
    void remove(int server_id) {
        if(dict.find(server_id) == dict.end()) { // no such server found
            return;
        }
        int index = dict[server_id];
        int lastIdx = servers.size() - 1;
        int lastVal = servers[lastIdx];
        servers[index] = lastVal; // use last node to replace the node on index, and remove the last node at O(1)
        dict[lastVal] = index;
        servers.pop_back();
        dict.erase(dict.find(server_id));
    }

    /*
     * @return: pick a server in the cluster randomly with equal probability
     */
    int pick() {
        int size = servers.size();
        return servers[rand() % size];  // get random number
    }

private:
    unordered_map<int, int> dict;
    vector<int> servers;
};