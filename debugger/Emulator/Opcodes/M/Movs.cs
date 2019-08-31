﻿namespace debugger.Emulator.Opcodes
{
    public class Movs : StringOperation
    {
        byte[] SourceBytes;
        public Movs(StringOpSettings settings = StringOpSettings.NONE) : base("MOVS", settings) { }
        protected override void OnInitialise()
        {
            SourceBytes = Fetch()[1];
        }
        protected override void OnExecute()
        {
            Set(SourceBytes);
        }
    }
}
