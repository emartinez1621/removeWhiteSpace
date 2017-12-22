using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace removeWhiteSpace
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var shit = File.ReadAllText("../../UA.txt");
            var myString = Regex.Replace(shit, @"\s+", " ");
            myString = myString.Replace("�", "'");
            myString = myString.Replace("'", "''");

            #region Spells
            #region Spell stats
            myString = myString.Replace("Casting Time:", "\r\n- **Casting Time:**");
                myString = myString.Replace("Range:", "\r\n- **Range:**");
                myString = myString.Replace("Components:", "\r\n- **Components:**");
                myString = myString.Replace("Duration:", "\r\n- **Duration:**");
                myString = myString.Replace("At Higher Levels.", "\r\n\r\n***At Higher Levels.***");
                myString = myString.Replace("Concentration, up to 1 minute", "Concentration, up to 1 minute\r\n\r\n");
                myString = myString.Replace("Instantaneous", "Instantaneous\r\n\r\n");
                myString = myString.Replace("Concentration, up to 1 hour", "Concentration, up to 1 hour\r\n\r\n");
                myString = myString.Replace("Concentration, up to 10 minutes", "Concentration, up to 10 minutes\r\n\r\n");
                myString = myString.Replace("• ", "\r\n* ");
                #endregion

                #region Spell List Spells
                myString = myString.Replace("Control flames (transmutation)", "*Control flames (transmutation)*</br>");
                myString = myString.Replace("Magic stone (transmutation)", "*Magic stone (transmutation)*</br>");
                myString = myString.Replace("Beast bond (divination)", "*Beast bond (divination)*</br>");
                myString = myString.Replace("Warding wind (evocation)", "*Warding wind (evocation)*</br>");
                myString = myString.Replace("Primordial ward (abjuration)", "*Primordial ward (abjuration)*</br>");
                myString = myString.Replace("Maelstrom (evocation)", "*Maelstrom (evocation)*</br>");
                myString = myString.Replace("Bones of the earth (transmutation)", "*Bones of the earth (transmutation)*</br>");
                myString = myString.Replace("Create bonfire (conjuration)", "*Create bonfire (conjuration)*</br>");
                myString = myString.Replace("Frostbite (evocation)", "*Frostbite (evocation)*</br>");
                myString = myString.Replace("Gust (transmutation)", "*Gust (transmutation)*</br>");
                myString = myString.Replace("Mold earth (transmutation)", "*Mold earth (transmutation)*</br>");
                myString = myString.Replace("Shape water (transmutation)", "*Shape water (transmutation)*</br>");
                myString = myString.Replace("Thunderclap (evocation)", "*Thunderclap (evocation)*</br>");
                myString = myString.Replace("Absorb elements (abjuration)", "*Absorb elements (abjuration)*</br>");
                myString = myString.Replace("Catapult (transmutation)", "*Catapult (transmutation)*</br>");
                myString = myString.Replace("Ice knife (conjuration)", "*Ice knife (conjuration)*</br>");
                myString = myString.Replace("Earth tremor (evocation)", "*Earth tremor (evocation)*</br>");
                myString = myString.Replace("Aganazzar’s scorcher (evocation)", "*Aganazzar's scorcher (evocation)*</br>");
                myString = myString.Replace("Dust devil (conjuration)", "*Dust devil (conjuration)*</br>");
                myString = myString.Replace("Earthbind (transmutation)", "*Earthbind (transmutation)*</br>");
                myString = myString.Replace("Maximilian’s earthen grasp (transmutation)", "*Maximilian's earthen grasp (transmutation)*</br>");
                myString = myString.Replace("Pyrotechnics (transmutation)", "*Pyrotechnics (transmutation)*</br>");
                myString = myString.Replace("Erupting earth (transmutation)", "*Erupting earth (transmutation)*</br>");
                myString = myString.Replace("Skywrite (transmutation, ritual)", "*Skywrite (transmutation, ritual)*</br>");
                myString = myString.Replace("Snilloc’s snowball swarm (evocation)", "*Snilloc's snowball swarm (evocation)*</br>");
                myString = myString.Replace("Flame arrows (transmutation)", "*Flame arrows (transmutation)*</br>");
                myString = myString.Replace("Melf’s minute meteors (evocation)", "*Melf's minute meteors (evocation)*</br>");
                myString = myString.Replace("Tidal wave (conjuration)", "*Tidal wave (conjuration)*</br>");
                myString = myString.Replace("Wall of sand (evocation)", "*Wall of sand (evocation)*</br>");
                myString = myString.Replace("Wall of water (evocation)", "*Wall of water (evocation)*</br>");
                myString = myString.Replace("Elemental bane (transmutation)", "*Elemental bane (transmutation)*</br>");
                myString = myString.Replace("Vitriolic sphere (evocation)", "*Vitriolic sphere (evocation)*</br>");
                myString = myString.Replace("Watery sphere (conjuration)", "*Watery sphere (conjuration)*</br>");
                myString = myString.Replace("Control winds (transmutation)", "*Control winds (transmutation)*</br>");
                myString = myString.Replace("Immolation (evocation)", "*Immolation (evocation)*</br>");
                myString = myString.Replace("Transmute rock (transmutation)", "*Transmute rock (transmutation)*</br>");
                myString = myString.Replace("Investiture of flame (transmutation)", "*Investiture of flame (transmutation)*</br>");
                myString = myString.Replace("Investiture of ice (transmutation)", "*Investiture of ice (transmutation)*</br>");
                myString = myString.Replace("Investiture of stone (transmutation)", "*Investiture of stone (transmutation)*</br>");
                myString = myString.Replace("Investiture of wind (transmutation)", "*Investiture of wind (transmutation)*</br>");
                myString = myString.Replace("Whirlwind (evocation)", "*Whirlwind (evocation)*</br>");
                myString = myString.Replace("Abi-Dalzim’s horrid wilting (necromancy)", "*Abi-Dalzim’s horrid wilting (necromancy)*</br>");

                #endregion

                #region Spell Levels
                myString = myString.Replace("Cantrips (0 Level)", "\r\n##### Cantrips (0 Level)\r\n");
                myString = myString.Replace("1st Level", "\r\n##### 1st Level\r\n");
                myString = myString.Replace("2nd Level", "\r\n\r\n##### 2nd Level\r\n");
                myString = myString.Replace("3rd Level", "\r\n\r\n##### 3rd Level\r\n");
                myString = myString.Replace("4th Level", "\r\n\r\n##### 4th Level\r\n");
                myString = myString.Replace("5th Level", "\r\n\r\n##### 5th Level\r\n");
                myString = myString.Replace("6th Level", "\r\n\r\n##### 6th Level\r\n");
                myString = myString.Replace("7th Level", "\r\n\r\n##### 7th Level\r\n");
                myString = myString.Replace("8th Level", "\r\n\r\n##### 8th Level\r\n");
                myString = myString.Replace("9th Level", "\r\n\r\n##### 9th Level\r\n");
                #endregion

                #region Abjuration
                myString = myString.Replace("Abjuration cantrip", "*Abjuration cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level abjuration", "*1st-level abjuration*\r\n___\r\n");
                myString = myString.Replace("2nd-level abjuration", "*2nd-level abjuration*\r\n___\r\n");
                myString = myString.Replace("3rd-level abjuration", "*3rd-level abjuration*\r\n___\r\n");
                myString = myString.Replace("4th-level abjuration", "*4th-level abjuration*\r\n___\r\n");
                myString = myString.Replace("5th-level abjuration ", "*5th-level abjuration *\r\n___\r\n");
                myString = myString.Replace("6th-level abjuration", "*6th-level abjuration*\r\n___\r\n");
                myString = myString.Replace("7th-level abjuration", "*7th-level abjuration*\r\n___\r\n");
                myString = myString.Replace("8th-level abjuration", "*8th-level abjuration*\r\n___\r\n");
                myString = myString.Replace("9th-level abjuration", "*9th-level abjuration*\r\n___\r\n");
                #endregion

                #region Conjuration
                myString = myString.Replace("Conjuration cantrip", "*Conjuration cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level conjuration", "*1st-level conjuration*\r\n___\r\n");
                myString = myString.Replace("2nd-level conjuration", "*2nd-level conjuration*\r\n___\r\n");
                myString = myString.Replace("3rd-level conjuration", "*3rd-level conjuration*\r\n___\r\n");
                myString = myString.Replace("4th-level conjuration", "*4th-level conjuration*\r\n___\r\n");
                myString = myString.Replace("5th-level conjuration ", "*5th-level conjuration *\r\n___\r\n");
                myString = myString.Replace("6th-level conjuration", "*6th-level conjuration*\r\n___\r\n");
                myString = myString.Replace("7th-level conjuration", "*7th-level conjuration*\r\n___\r\n");
                myString = myString.Replace("8th-level conjuration", "*8th-level conjuration*\r\n___\r\n");
                myString = myString.Replace("9th-level conjuration", "*9th-level conjuration*\r\n___\r\n");
                #endregion

                #region Divination
                myString = myString.Replace("Divination cantrip", "*Divination cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level divination", "*1st-level divination*\r\n___\r\n");
                myString = myString.Replace("2nd-level divination", "*2nd-level divination*\r\n___\r\n");
                myString = myString.Replace("3rd-level divination", "*3rd-level divination*\r\n___\r\n");
                myString = myString.Replace("4th-level divination", "*4th-level divination*\r\n___\r\n");
                myString = myString.Replace("5th-level divination ", "*5th-level divination *\r\n___\r\n");
                myString = myString.Replace("6th-level divination", "*6th-level divination*\r\n___\r\n");
                myString = myString.Replace("7th-level divination", "*7th-level divination*\r\n___\r\n");
                myString = myString.Replace("8th-level divination", "*8th-level divination*\r\n___\r\n");
                myString = myString.Replace("9th-level divination", "*9th-level divination*\r\n___\r\n");
                #endregion

                #region Enchantment
                myString = myString.Replace("Enchantment cantrip", "*Enchantment cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level enchantment", "*1st-level enchantment*\r\n___\r\n");
                myString = myString.Replace("2nd-level enchantment", "*2nd-level enchantment*\r\n___\r\n");
                myString = myString.Replace("3rd-level enchantment", "*3rd-level enchantment*\r\n___\r\n");
                myString = myString.Replace("4th-level enchantment", "*4th-level enchantment*\r\n___\r\n");
                myString = myString.Replace("5th-level enchantment ", "*5th-level enchantment *\r\n___\r\n");
                myString = myString.Replace("6th-level enchantment", "*6th-level enchantment*\r\n___\r\n");
                myString = myString.Replace("7th-level enchantment", "*7th-level enchantment*\r\n___\r\n");
                myString = myString.Replace("8th-level enchantment", "*8th-level enchantment*\r\n___\r\n");
                myString = myString.Replace("9th-level enchantment", "*9th-level enchantment*\r\n___\r\n");
                #endregion

                #region Evocation
                myString = myString.Replace("Evocation cantrip", "*Evocation cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level evocation", "*1st-level evocation*\r\n___\r\n");
                myString = myString.Replace("2nd-level evocation", "*2nd-level evocation*\r\n___\r\n");
                myString = myString.Replace("3rd-level evocation", "*3rd-level evocation*\r\n___\r\n");
                myString = myString.Replace("4th-level evocation", "*4th-level evocation*\r\n___\r\n");
                myString = myString.Replace("5th-level evocation ", "*5th-level evocation *\r\n___\r\n");
                myString = myString.Replace("6th-level evocation", "*6th-level evocation*\r\n___\r\n");
                myString = myString.Replace("7th-level evocation", "*7th-level evocation*\r\n___\r\n");
                myString = myString.Replace("8th-level evocation", "*8th-level evocation*\r\n___\r\n");
                myString = myString.Replace("9th-level evocation", "*9th-level evocation*\r\n___\r\n");
                #endregion

                #region Illusion
                myString = myString.Replace("Illusion cantrip", "*Illusion cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level illusion", "*1st-level illusion*\r\n___\r\n");
                myString = myString.Replace("2nd-level illusion", "*2nd-level illusion*\r\n___\r\n");
                myString = myString.Replace("3rd-level illusion", "*3rd-level illusion*\r\n___\r\n");
                myString = myString.Replace("4th-level illusion", "*4th-level illusion*\r\n___\r\n");
                myString = myString.Replace("5th-level illusion ", "*5th-level illusion *\r\n___\r\n");
                myString = myString.Replace("6th-level illusion", "*6th-level illusion*\r\n___\r\n");
                myString = myString.Replace("7th-level illusion", "*7th-level illusion*\r\n___\r\n");
                myString = myString.Replace("8th-level illusion", "*8th-level illusion*\r\n___\r\n");
                myString = myString.Replace("9th-level illusion", "*9th-level illusion*\r\n___\r\n");
                #endregion

                #region Necromancy
                myString = myString.Replace("Necromancy cantrip", "*Necromancy cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level necromancy", "*1st-level necromancy*\r\n___\r\n");
                myString = myString.Replace("2nd-level necromancy", "*2nd-level necromancy*\r\n___\r\n");
                myString = myString.Replace("3rd-level necromancy", "*3rd-level necromancy*\r\n___\r\n");
                myString = myString.Replace("4th-level necromancy", "*4th-level necromancy*\r\n___\r\n");
                myString = myString.Replace("5th-level necromancy ", "*5th-level necromancy *\r\n___\r\n");
                myString = myString.Replace("6th-level necromancy", "*6th-level necromancy*\r\n___\r\n");
                myString = myString.Replace("7th-level necromancy", "*7th-level necromancy*\r\n___\r\n");
                myString = myString.Replace("8th-level necromancy", "*8th-level necromancy*\r\n___\r\n");
                myString = myString.Replace("9th-level necromancy", "*9th-level necromancy*\r\n___\r\n");
                #endregion

                #region Transmutation
                myString = myString.Replace("Transmutation cantrip", "*Transmutation cantrip*\r\n___\r\n");
                myString = myString.Replace("1st-level transmutation", "*1st-level transmutation*\r\n___\r\n");
                myString = myString.Replace("2nd-level transmutation", "*2nd-level transmutation*\r\n___\r\n");
                myString = myString.Replace("3rd-level transmutation", "*3rd-level transmutation*\r\n___\r\n");
                myString = myString.Replace("4th-level transmutation", "*4th-level transmutation*\r\n___\r\n");
                myString = myString.Replace("5th-level transmutation ", "*5th-level transmutation *\r\n___\r\n");
                myString = myString.Replace("6th-level transmutation", "*6th-level transmutation*\r\n___\r\n");
                myString = myString.Replace("7th-level transmutation", "*7th-level transmutation*\r\n___\r\n");
                myString = myString.Replace("8th-level transmutation", "*8th-level transmutation*\r\n___\r\n");
                myString = myString.Replace("9th-level transmutation", "*9th-level transmutation*\r\n___\r\n"); 
                #endregion
            #endregion
            Clipboard.SetText(" = '" + myString + "'");
            //Clipboard.SetText(myString);



        }
    }
}