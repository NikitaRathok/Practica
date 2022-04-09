namespace num4
{
    
        class MyInfo
        {
            string name = "Никита";
            public delegate void Info(string name);
            public event Info Changed;
            public void OnChanged(string n)
            {
                if (name != n)
                {
                    Changed(n);
                    name = n;
                }
            }
        }
    
}
