namespace InheritanceTask
{
    public class Girl:Human
    {
        private const string _GENDER = "Girl";
        private string _boyfriendName;

        public Girl(int age, string name, double height, string boyfriendName) : base(age, name, height, _GENDER)
        {
            _boyfriendName = boyfriendName;
        }

        public string BoyfriendName
        {
            get => _boyfriendName;
            set => _boyfriendName = value;
        }

        public override string Gender
        {
            get => _GENDER;
        }

        public override string ToString()
        {
            return base.ToString()+"Boyfriend:"+_boyfriendName;
        }
    }
}