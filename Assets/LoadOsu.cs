using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OsuLoader;
using System.IO;
using UnityEngine.UI;

public class LoadOsu : MonoBehaviour {
    string Path,OsuPath;
    public Text drawUI,drawS;

    private void ScanBeatMap() {

        Path = Application.dataPath + "/BeatMap/";

        DirectoryInfo dir = new DirectoryInfo(Path);
        FileInfo[] info = dir.GetFiles("*.*");
        foreach (FileInfo f in info)
        {
            //Debug.Log(f);
        }

    }

    void Awake()
    {
        ScanBeatMap();
        OsuPath = Path + "/664315 Cass2 - Gravity Falls Theme Song- 16 Bit Mix/Cass2 - Gravity Falls Theme Song- 16 Bit Mix (Venix) [Pachiru's Normal].osu";
        //        string[] a = OsuLoader.OsuLoader.LoadDotOsu(OsuPath);
        string Judul = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).Title;
        string JudulUnicode = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).TitleUnicode;
        string Difficulty = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).Version;
        string Artis = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).Artist;
        string ArtisUnicode = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).ArtistUnicode;
        int BeatmapID = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).BeatmapID;
        string Pembuat = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).Creator;
        float HPdrain = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).HPDrainRate;
        float Diff = OsuLoader.OsuLoader.LoadDotOsu(OsuPath).OverallDifficulty;
        Debug.Log(OsuLoader.OsuLoader.LoadDotOsu(OsuPath).SingleNotes.Count);



        /*for (var i = 0; i < OsuLoader.OsuLoader.LoadDotOsu(OsuPath).SingleNotes.Count;i++ ) {
            Debug.Log(i);
        }
        */


            drawUI.text = "Judul : " + JudulUnicode + " (Unicode)\n"
            + "Difficulty : " + Difficulty + 
            "\nArtis : " + ArtisUnicode + " (Unicode)\n" 
            + "Beatmap ID : " + BeatmapID + 
            "\nPembuat : " + Pembuat + 
            "\nHP Drain : " + HPdrain + 
            "\nBintang? : " + Diff;



    }

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}
}
