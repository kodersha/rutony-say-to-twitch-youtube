using System.IO;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Net;

namespace RutonyChat {
    public class Script {

        public void InitParams(string param) {
            RutonyBot.SayToWindow("Плагин общего чата включен");
        }

        public void Closing() {

        }

        public void NewMessage(string site, string name, string text, bool system) {
            if (system) {
                return;
            }

            if (!( name == "Имя бота" ) && !( name == "Twitch" ) && !( name == "YouTube" )) {
                if ( site.ToLower() == "twitch" ) {
                    RutonyBot.BotSay("youtube", "[" + name + "] " + text);
                } else if ( site.ToLower() == "youtube" ) {
                    RutonyBot.BotSay("twitch", "[" + name + "] " + text);
                } else {

                }
            }
        }
    }
}
