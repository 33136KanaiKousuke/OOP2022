﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    public class Song {

        public string Title { get; set; }//歌のタイトル

        public string ArtistName { get; set; }//アーティスト名

        public int Length { get; set; }//演奏時間(秒)

        //引数付きコンストラクタ
        public Song(string Title, string ArtistName, int Length) {
            
        }

    }
}
