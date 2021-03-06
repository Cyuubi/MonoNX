using MonoNX.OsHle.Objects.Acc;

using static MonoNX.OsHle.Objects.ObjHelper;

namespace MonoNX.OsHle.Services
{
    static partial class Service
    {
        public static long AccU0ListOpenUsers(ServiceCtx Context)
        {
            return 0;
        }

        public static long AccU0GetProfile(ServiceCtx Context)
        {
            MakeObject(Context, new IProfile());

            return 0;
        }

        public static long AccU0InitializeApplicationInfo(ServiceCtx Context)
        {
            return 0;
        }

        public static long AccU0GetBaasAccountManagerForApplication(ServiceCtx Context)
        {
            MakeObject(Context, new IManagerForApplication());

            return 0;
        }
    }
}