public List<int> Breadth(BinaryTree T)
{

    if (T.root == null)
    {
        throw new Exception(" Tree is Empty ! ");
    }

    Queue<Node> Q = new Queue<Node>();
    List<int> res = new List<int>();
    Q.Enqueue(T.root);
    while (Q.Count > 0)
    {

        Node F = Q.Peek();
        res.Add(F.data);
        Q.Dequeue();
        if (F != null)
        {
            continue;
        }
        if (F.left != null)
        {
            Q.Enqueue(F.left);
        }
        if (F.right != null)
        {
            Q.Enqueue(F.right);
        }
    }
    return res;

}
