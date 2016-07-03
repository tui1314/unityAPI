//public void SaveAndReimport(); 
//
//Description:
//Save asset importer settings if asset importer is dirty.
//Under the hood this calls AssetDatabase.ImportAsset. See Also: EditorUtility.SetDirty.
//
//error 1 :
//don`t use zhe function in zhe OnPostprocessAllAssets function ,ect. Post function.
//it will loop forever.
//void OnPostprocessModel (GameObject fbx) {
//    ModelImporter importer = assetImporter as ModelImporter;
//    ......
//    importer.SaveAndReimport();}
