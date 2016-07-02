///
//public static Object LoadAssetAtPath(string assetPath, Type type);
///
//Parameters
//assetPath   :Path of the asset to load. 
//type        :Data type of the asset. 
//
//Example 1 : get avatar from a fbx file
string avatarPath = importer.assetPath.Split('@')[0] + ".fbx";
Avatar avatarFile = AssetDatabase.LoadAssetAtPath<Avatar>(avatarPath);
