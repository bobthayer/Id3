#region --- License & Copyright Notice ---
/*
Copyright (c) 2005-2018 Jeevan James
All rights reserved.

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
#endregion

namespace Id3
{
    public sealed class LyricsFrame : Id3Frame
    {
        public override bool Equals(Id3Frame other)
        {
            return other is LyricsFrame lyricsFrame &&
                lyricsFrame.Language == Language &&
                lyricsFrame.Description == Description;
        }

        public string Description { get; set; }

        public Id3TextEncoding EncodingType { get; set; }

        public override bool IsAssigned => !string.IsNullOrEmpty(Lyrics);

        public Id3Language Language { get; set; } = Id3Language.eng;

        public string Lyrics { get; set; }
    }
}