import compileall
import os

compileall.compile_dir(os.path.dirname(__file__) + "/QDSPythonSDK" , force=True)