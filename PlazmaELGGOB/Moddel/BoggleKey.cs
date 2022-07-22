namespace PlazmaELGGOB.Moddel
{
    public class BoggleKey
    {
        public int Space { get; set; }
        public char Letter { get; set; }
        public bool Clicked { get; set; }

        // this will include which indexes are alowed to be clicked, folowing this button being clicked.
        public int[] allowedIndexes { get; set; }

        public BoggleKey(int space, char letter, bool clicked, int[] allowedIndexes)
        {
            Space = space;
            Letter = letter;
            Clicked = clicked;
            this.allowedIndexes = allowedIndexes;
        }
    }
}
