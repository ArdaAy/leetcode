public class MyLinkedList {

    private List<int> iList;
    public MyLinkedList() {
        this.iList = new List<int>();
    }
    
    public int Get(int index) {
        if(iList.Count > index)
            return this.iList[index];
        return -1;
    }
    
    public void AddAtHead(int val) {
        this.iList.Insert(0,val);
        /*
        List<int> newList = new iList<int> {val};
        foreach(int i in this.iList)
            newList.Add(i);
        this.iList = newList;
        */
    }
    
    public void AddAtTail(int val) {
        this.iList.Add(val);
    }
    
    public void AddAtIndex(int index, int val) {
        if(iList.Count > index )
            this.iList.Insert(index,val);
        else if(iList.Count == index)
            this.iList.Add(val);
    }
    
    public void DeleteAtIndex(int index) {
        if(iList.Count > index )
            this.iList.RemoveAt(index);
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */