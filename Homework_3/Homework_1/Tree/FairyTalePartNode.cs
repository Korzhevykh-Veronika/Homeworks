using System.Collections.Generic;

namespace Homework_1.Tree
{
    public class FairyTalePartNode
    {
        public string Description;
        public string Text;
        public List<FairyTalePartNode> Children;

        public FairyTalePartNode(string description, string text, List<FairyTalePartNode> children)
        {
            Description = description;
            Text = text;
            Children = children;
        }

        public void Process()
        {
            System.Console.WriteLine(Text);

            if (Children != null) ShowNext();
            else ;
        }

        private void ShowNext()
        {
            IPicker picker = new ChildrenNodePicker();
            int index = picker.PickNode(Children);
            
            Children[index].Process();
        }
    }
}
