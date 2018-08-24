using System;

namespace Editor
{
    using UnityEngine;
    using UnityEditor;
    using UniLua.Tools;
    using System;
    public class TestCompiler 
    {
        [MenuItem("LuaTools/TestCompileToProto")]
        public static void TestCompileToProto()
        {
            var proto = Compiler.CompileFile(string.Format("{0}/LuaScript/{1}", Application.streamingAssetsPath, "test1.lua"));
            Compiler.DumpingToFile(proto,string.Format("{0}/LuaScript/{1}", Application.streamingAssetsPath, "test1.proto"),true);
        }
    }
}