///
//public static Object LoadAssetAtPath(string assetPath, Type type);
///
//Parameters
//assetPath   :Path of the asset to load. 
//type        :Data type of the asset. 
//
//Description
//Returns the first asset object of type type at given path assetPath.
//
//Some asset files may contain multiple objects. (such as a Maya file which may contain multiple Meshes and GameObjects).
//All paths are relative to the project folder, for example: "Assets/MyTextures/hello.png".

//Example 1 : get avatar from a fbx file
string avatarPath = importer.assetPath.Split('@')[0] + ".fbx";
Avatar avatarFile = AssetDatabase.LoadAssetAtPath<Avatar>(avatarPath);
