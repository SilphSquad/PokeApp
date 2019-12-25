let basestats =
    [|("001","Bulbasaur","128","118","111");
    ("002","Ivysaur","155","151","143");
    ("003","Venusaur","190","198","189");
    ("004","Charmander","118","116","93");
    ("005","Charmeleon","151","158","126");
    ("006","Charizard","186","223","173");
    ("007","Squirtle","127","94","121");
    ("008","Wartortle","153","126","155");
    ("009","Blastoise","188","171","207");
    ("010","Caterpie","128","55","55");
    ("011","Metapod","137","45","80");
    ("012","Butterfree","155","167","137");
    ("013","Weedle","120","63","50");
    ("014","Kakuna","128","46","75");
    ("015","Beedrill","163","169","130");
    ("016","Pidgey","120","85","73");
    ("017","Pidgeotto","160","117","105");
    ("018","Pidgeot","195","166","154");
    ("019","Rattata","102","103","70");
    ("019A","Alolan Rattata","102","103","70");
    ("020","Raticate","146","161","139");
    ("020A","Alolan Raticate","181","135","154");
    ("021","Spearow","120","112","60");
    ("022","Fearow","163","182","133");
    ("023","Ekans","111","110","97");
    ("024","Arbok","155","167","153");
    ("025","Pikachu","111","112","96");
    ("026","Raichu","155","193","151");
    ("026A","Alolan Raichu","155","201","154");
    ("027","Sandshrew","137","126","120");
    ("027A","Alolan Sandshrew","137","125","129");
    ("028","Sandslash","181","182","175");
    ("028A","Alolan Sandslash","181","177","195");
    ("029","Nidoran?","146","86","89");
    ("030","Nidorina","172","117","120");
    ("031","Nidoqueen","207","180","173");
    ("032","Nidoran?","130","105","76");
    ("033","Nidorino","156","137","111");
    ("034","Nidoking","191","204","156");
    ("035","Clefairy","172","107","108");
    ("036","Clefable","216","178","162");
    ("037","Vulpix","116","96","109");
    ("037A","Alolan Vulpix","116","96","109");
    ("038","Ninetales","177","169","190");
    ("038A","Alolan Ninetales","177","170","193");
    ("039","Jigglypuff","251","80","41");
    ("040","Wigglytuff","295","156","90");
    ("041","Zubat","120","83","73");
    ("042","Golbat","181","161","150");
    ("043","Oddish","128","131","112");
    ("044","Gloom","155","153","136");
    ("045","Vileplume","181","202","167");
    ("046","Paras","111","121","99");
    ("047","Parasect","155","165","146");
    ("048","Venonat","155","100","100");
    ("049","Venomoth","172","179","143");
    ("050","Diglett","67","109","78");
    ("050A","Alolan Diglett","67","108","81");
    ("051","Dugtrio","111","167","134");
    ("051A","Alolan Dugtrio","111","201","142");
    ("052","Meowth","120","92","78");
    ("052A","Alolan Meowth","120","99","78");
    ("053","Persian","163","150","136");
    ("053A","Alolan Persian","163","158","136");
    ("054","Psyduck","137","122","95");
    ("055","Golduck","190","191","162");
    ("056","Mankey","120","148","82");
    ("057","Primeape","163","207","138");
    ("058","Growlithe","146","136","93");
    ("059","Arcanine","207","227","166");
    ("060","Poliwag","120","101","82");
    ("061","Poliwhirl","163","130","123");
    ("062","Poliwrath","207","182","184");
    ("063","Abra","93","195","82");
    ("064","Kadabra","120","232","117");
    ("065","Alakazam","146","271","167");
    ("066","Machop","172","137","82");
    ("067","Machoke","190","177","125");
    ("068","Machamp","207","234","159");
    ("069","Bellsprout","137","139","61");
    ("070","Weepinbell","163","172","92");
    ("071","Victreebel","190","207","135");
    ("072","Tentacool","120","97","149");
    ("073","Tentacruel","190","166","209");
    ("074","Geodude","120","132","132");
    ("074A","Alolan Geodude","120","132","132");
    ("075","Graveler","146","164","164");
    ("075A","Alolan Graveler","146","164","164");
    ("076","Golem","190","211","198");
    ("076A","Alolan Golem","190","211","198");
    ("077","Ponyta","137","170","127");
    ("078","Rapidash","163","207","162");
    ("079","Slowpoke","207","109","98");
    ("080","Slowbro","216","177","180");
    ("081","Magnemite","93","165","121");
    ("082","Magneton","137","223","169");
    ("083","Farfetchd","141","124","115");
    ("084","Doduo","111","158","83");
    ("085","Dodrio","155","218","140");
    ("086","Seel","163","85","121");
    ("087","Dewgong","207","139","177");
    ("088","Grimer","190","135","90");
    ("088A","Alolan Grimer","190","135","90");
    ("089","Muk","233","190","172");
    ("089A","Alolan Muk","233","190","172");
    ("090","Shellder","102","116","134");
    ("091","Cloyster","137","186","256");
    ("092","Gastly","102","186","67");
    ("093","Haunter","128","223","107");
    ("094","Gengar","155","261","149");
    ("095","Onix","111","85","232");
    ("096","Drowzee","155","89","136");
    ("097","Hypno","198","144","193");
    ("098","Krabby","102","181","124");
    ("099","Kingler","146","240","181");
    ("100","Voltorb","120","109","111");
    ("101","Electrode","155","173","173");
    ("102","Exeggcute","155","107","125");
    ("103","Exeggutor","216","233","149");
    ("103A","Exeggutor","216","230","153");
    ("104","Cubone","137","90","144");
    ("105","Marowak","155","144","186");
    ("105A","Alolan Marowak","155","144","186");
    ("106","Hitmonlee","137","224","181");
    ("107","Hitmonchan","137","193","197");
    ("108","Lickitung","207","108","137");
    ("109","Koffing","120","119","141");
    ("110","Weezing","163","174","197");
    ("111","Rhyhorn","190","140","127");
    ("112","Rhydon","233","222","171");
    ("113","Chansey","487","60","128");
    ("114","Tangela","163","183","169");
    ("115","Kangaskhan","233","181","165");
    ("116","Horsea","102","129","103");
    ("117","Seadra","146","187","156");
    ("118","Goldeen","128","123","110");
    ("119","Seaking","190","175","147");
    ("120","Staryu","102","137","112");
    ("121","Starmie","155","210","184");
    ("122","Mr. Mime","120","192","205");
    ("123","Scyther","172","218","170");
    ("124","Jynx","163","223","151");
    ("125","Electabuzz","163","198","158");
    ("126","Magmar","163","206","154");
    ("127","Pinsir","163","238","182");
    ("128","Tauros","181","198","183");
    ("129","Magikarp","85","29","85");
    ("130","Gyarados","216","237","186");
    ("131","Lapras","277","165","174");
    ("132","Ditto","134","91","91");
    ("133","Eevee","146","104","114");
    ("134","Vaporeon","277","205","161");
    ("135","Jolteon","163","232","182");
    ("136","Flareon","163","246","179");
    ("137","Porygon","163","153","136");
    ("138","Omanyte","111","155","153");
    ("139","Omastar","172","207","201");
    ("140","Kabuto","102","148","140");
    ("141","Kabutops","155","220","186");
    ("142","Aerodactyl","190","221","159");
    ("143","Snorlax","330","190","169");
    ("144","Articuno","207","192","236");
    ("145","Zapdos","207","253","185");
    ("146","Moltres","207","251","181");
    ("147","Dratini","121","119","91");
    ("148","Dragonair","156","163","135");
    ("149","Dragonite","209","263","198");
    ("150","Mewtwo","214","300","182");
    ("151","Mew","225","210","210");
    ("152","Chikorita","128","92","122");
    ("153","Bayleef","155","122","155");
    ("154","Meganium","190","168","202");
    ("155","Cyndaquil","118","116","93");
    ("156","Quilava","151","158","126");
    ("157","Typhlosion","186","223","173");
    ("158","Totodile","137","117","109");
    ("159","Croconaw","163","150","142");
    ("160","Feraligatr","198","205","188");
    ("161","Sentret","111","79","73");
    ("162","Furret","198","148","125");
    ("163","Hoothoot","155","67","88");
    ("164","Noctowl","225","145","156");
    ("165","Ledyba","120","72","118");
    ("166","Ledian","146","107","179");
    ("167","Spinarak","120","105","73");
    ("168","Ariados","172","161","124");
    ("169","Crobat","198","194","178");
    ("170","Chinchou","181","106","97");
    ("171","Lanturn","268","146","137");
    ("172","Pichu","85","77","53");
    ("173","Cleffa","137","75","79");
    ("174","Igglybuff","207","69","32");
    ("175","Togepi","111","67","116");
    ("176","Togetic","146","139","181");
    ("177","Natu","120","134","89");
    ("178","Xatu","163","192","146");
    ("179","Mareep","146","114","79");
    ("180","Flaaffy","172","145","109");
    ("181","Ampharos","207","211","169");
    ("182","Bellossom","181","169","186");
    ("183","Marill","172","37","93");
    ("184","Azumarill","225","112","152");
    ("185","Sudowoodo","172","167","176");
    ("186","Politoed","207","174","179");
    ("187","Hoppip","111","67","94");
    ("188","Skiploom","146","91","120");
    ("189","Jumpluff","181","118","183");
    ("190","Aipom","146","136","112");
    ("191","Sunkern","102","55","55");
    ("192","Sunflora","181","185","135");
    ("193","Yanma","163","154","94");
    ("194","Wooper","146","75","66");
    ("195","Quagsire","216","152","143");
    ("196","Espeon","163","261","175");
    ("197","Umbreon","216","126","240");
    ("198","Murkrow","155","175","87");
    ("199","Slowking","216","177","180");
    ("200","Misdreavus","155","167","154");
    ("201","Unown","134","136","91");
    ("202","Wobbuffet","382","60","106");
    ("203","Girafarig","172","182","133");
    ("204","Pineco","137","108","122");
    ("205","Forretress","181","161","205");
    ("206","Dunsparce","225","131","128");
    ("207","Gligar","163","143","184");
    ("208","Steelix","181","148","272");
    ("209","Snubbull","155","137","85");
    ("210","Granbull","207","212","131");
    ("211","Qwilfish","163","184","138");
    ("212","Scizor","172","236","181");
    ("213","Shuckle","85","17","396");
    ("214","Heracross","190","234","179");
    ("215","Sneasel","146","189","146");
    ("216","Teddiursa","155","142","93");
    ("217","Ursaring","207","236","144");
    ("218","Slugma","120","118","71");
    ("219","Magcargo","137","139","191");
    ("220","Swinub","137","90","69");
    ("221","Piloswine","225","181","138");
    ("222","Corsola","146","118","156");
    ("223","Remoraid","111","127","69");
    ("224","Octillery","181","197","141");
    ("225","Delibird","128","128","90");
    ("226","Mantine","163","148","226");
    ("227","Skarmory","163","148","226");
    ("228","Houndour","128","152","83");
    ("229","Houndoom","181","224","144");
    ("230","Kingdra","181","194","194");
    ("231","Phanpy","207","107","98");
    ("232","Donphan","207","214","185");
    ("233","Porygon2","198","198","180");
    ("234","Stantler","177","192","131");
    ("235","Smeargle","146","40","83");
    ("236","Tyrogue","111","64","64");
    ("237","Hitmontop","137","173","207");
    ("238","Smoochum","128","153","91");
    ("239","Elekid","128","135","101");
    ("240","Magby","128","151","99");
    ("241","Miltank","216","157","193");
    ("242","Blissey","496","129","169");
    ("243","Raikou","207","241","195");
    ("244","Entei","251","235","171");
    ("245","Suicune","225","180","235");
    ("246","Larvitar","137","115","93");
    ("247","Pupitar","172","155","133");
    ("248","Tyranitar","225","251","207");
    ("249","Lugia","235","193","310");
    ("250","Ho-Oh","214","239","244");
    ("251","Celebi","225","210","210");
    ("252","Treecko","120","124","94");
    ("253","Grovyle","137","172","120");
    ("254","Sceptile","172","223","169");
    ("255","Torchic","128","130","87");
    ("256","Combusken","155","163","115");
    ("257","Blaziken","190","240","141");
    ("258","Mudkip","137","126","93");
    ("259","Marshtomp","172","156","133");
    ("260","Swampert","225","208","175");
    ("261","Poochyena","111","96","61");
    ("262","Mightyena","172","171","132");
    ("263","Zigzagoon","116","58","80");
    ("264","Linoone","186","142","128");
    ("265","Wurmple","128","75","59");
    ("266","Silcoon","137","60","77");
    ("267","Beautifly","155","189","98");
    ("268","Cascoon","137","60","77");
    ("269","Dustox","155","98","162");
    ("270","Lotad","120","71","77");
    ("271","Lombre","155","112","119");
    ("272","Ludicolo","190","173","176");
    ("273","Seedot","120","71","77");
    ("274","Nuzleaf","172","134","78");
    ("275","Shiftry","207","200","121");
    ("276","Taillow","120","106","61");
    ("277","Swellow","155","185","124");
    ("278","Wingull","120","106","61");
    ("279","Pelipper","155","175","174");
    ("280","Ralts","99","79","59");
    ("281","Kirlia","116","117","90");
    ("282","Gardevoir","169","237","195");
    ("283","Surskit","120","93","87");
    ("284","Masquerain","172","192","150");
    ("285","Shroomish","155","74","110");
    ("286","Breloom","155","241","144");
    ("287","Slakoth","155","104","92");
    ("288","Vigoroth","190","159","145");
    ("289","Slaking","284","290","166");
    ("290","Nincada","104","80","126");
    ("291","Ninjask","156","199","112");
    ("292","Shedinja","1","153","73");
    ("293","Whismur","162","92","42");
    ("294","Loudred","197","134","81");
    ("295","Exploud","232","179","137");
    ("296","Makuhita","176","99","54");
    ("297","Hariyama","302","209","114");
    ("298","Azurill","137","36","71");
    ("299","Nosepass","102","82","215");
    ("300","Skitty","137","84","79");
    ("301","Delcatty","172","132","127");
    ("302","Sableye","137","141","136");
    ("303","Mawile","137","155","141");
    ("304","Aron","137","121","141");
    ("305","Lairon","155","158","198");
    ("306","Aggron","172","198","257");
    ("307","Meditite","102","78","107");
    ("308","Medicham","155","121","152");
    ("309","Electrike","120","123","78");
    ("310","Manectric","172","215","127");
    ("311","Plusle","155","167","129");
    ("312","Minun","155","147","150");
    ("313","Volbeat","163","143","166");
    ("314","Illumise","163","143","166");
    ("315","Roselia","137","186","131");
    ("316","Gulpin","172","80","99");
    ("317","Swalot","225","140","159");
    ("318","Carvanha","128","171","39");
    ("319","Sharpedo","172","243","83");
    ("320","Wailmer","277","136","68");
    ("321","Wailord","347","175","87");
    ("322","Numel","155","119","79");
    ("323","Camerupt","172","194","136");
    ("324","Torkoal","172","151","203");
    ("325","Spoink","155","125","122");
    ("326","Grumpig","190","171","188");
    ("327","Spinda","155","116","116");
    ("328","Trapinch","128","162","78");
    ("329","Vibrava","137","134","99");
    ("330","Flygon","190","205","168");
    ("331","Cacnea","137","156","74");
    ("332","Cacturne","172","221","115");
    ("333","Swablu","128","76","132");
    ("334","Altaria","181","141","201");
    ("335","Zangoose","177","222","124");
    ("336","Seviper","177","196","118");
    ("337","Lunatone","207","178","153");
    ("338","Solrock","207","178","153");
    ("339","Barboach","137","93","82");
    ("340","Whiscash","242","151","141");
    ("341","Corphish","125","141","99");
    ("342","Crawdaunt","160","224","142");
    ("343","Baltoy","120","77","124");
    ("344","Claydol","155","140","229");
    ("345","Lileep","165","105","150");
    ("346","Cradily","200","152","194");
    ("347","Anorith","128","176","100");
    ("348","Armaldo","181","222","174");
    ("349","Feebas","85","29","85");
    ("350","Milotic","216","192","219");
    ("351","Castform","172","139","139");
    ("351R","Castform (Rainy)","172","139","139");
    ("351H","Castform (Snowy)","172","139","139");
    ("351S","Castform (Sunny)","172","139","139");
    ("352","Kecleon","155","161","189");
    ("353","Shuppet","127","138","65");
    ("354","Banette","162","218","126");
    ("355","Duskull","85","70","162");
    ("356","Dusclops","120","124","234");
    ("357","Tropius","223","136","163");
    ("358","Chimecho","181","175","170");
    ("359","Absol","163","246","120");
    ("360","Wynaut","216","41","86");
    ("361","Snorunt","137","95","95");
    ("362","Glalie","190","162","162");
    ("363","Spheal","172","95","90");
    ("364","Sealeo","207","137","132");
    ("365","Walrein","242","182","176");
    ("366","Clamperl","111","133","135");
    ("367","Huntail","146","197","179");
    ("368","Gorebyss","146","211","179");
    ("369","Relicanth","225","162","203");
    ("370","Luvdisc","125","81","128");
    ("371","Bagon","128","134","93");
    ("372","Shelgon","163","172","155");
    ("373","Salamence","216","277","168");
    ("374","Beldum","120","96","132");
    ("375","Metang","155","138","176");
    ("376","Metagross","190","257","228");
    ("377","Regirock","190","179","309");
    ("378","Regice","190","179","309");
    ("379","Registeel","190","143","285");
    ("380","Latias","190","228","246");
    ("381","Latios","190","268","212");
    ("382","Kyogre","205","270","228");
    ("383","Groudon","205","270","228");
    ("384","Rayquaza","213","284","170");
    ("385","Jirachi","225","210","210");
    ("386","Deoxys","137","345","115");
    ("386A","Deoxys (Attack)","137","414","46");
    ("386D","Deoxys (Defense)","137","144","330");
    ("386S","Deoxys (Speed)","137","230","218");
    ("387","Turtwig","146","119","110");
    ("388","Grotle","181","157","143");
    ("389","Torterra","216","202","188");
    ("390","Chimchar","127","113","86");
    ("391","Monferno","162","158","105");
    ("392","Infernape","183","222","151");
    ("393","Piplup","142","112","102");
    ("394","Prinplup","162","150","139");
    ("395","Empoleon","197","210","186");
    ("396","Starly","120","101","58");
    ("397","Staravia","146","142","94");
    ("398","Staraptor","198","234","140");
    ("399","Bidoof","153","80","73");
    ("400","Bibarel","188","162","119");
    ("401","Kricketot","114","45","74");
    ("402","Kricketune","184","160","100");
    ("403","Shinx","128","117","64");
    ("404","Luxio","155","159","95");
    ("405","Luxray","190","232","156");
    ("406","Budew","120","91","109");
    ("407","Roserade","155","243","185");
    ("408","Cranidos","167","218","71");
    ("409","Rampardos","219","295","109");
    ("410","Shieldon","102","76","195");
    ("411","Bastiodon","155","94","286");
    ("412","Burmy (Plant)","120","53","83");
    ("412G","Burmy (Sandy)","120","53","83");
    ("412S","Burmy (Trash)","120","53","83");
    ("413","Wormadam (Plant)","155","141","180");
    ("413G","Wormadam (Sandy)","155","141","180");
    ("413S","Wormadam (Trash)","155","127","175");
    ("414","Mothim","172","185","98");
    ("415","Combee","102","59","83");
    ("416","Vespiquen","172","149","190");
    ("417","Pachirisu","155","94","172");
    ("418","Buizel","146","132","67");
    ("419","Floatzel","198","221","114");
    ("420","Cherubi","128","108","92");
    ("421","Cherrim (Overcast)","172","170","153");
    ("421S","Cherrim (Sunshine)","172","170","153");
    ("422","Shellos (West Sea)","183","103","105");
    ("422E","Shellos (East Sea)","183","103","105");
    ("423","Gastrodon (West Sea)","244","169","143");
    ("423E","Gastrodon (East Sea)","244","169","143");
    ("424","Ambipom","181","205","143");
    ("425","Drifloon","207","117","80");
    ("426","Drifblim","312","180","102");
    ("427","Buneary","146","130","105");
    ("428","Lopunny","163","156","194");
    ("429","Mismagius","155","211","187");
    ("430","Honchkrow","225","243","103");
    ("431","Glameow","135","109","82");
    ("432","Purugly","174","172","133");
    ("433","Chingling","128","114","94");
    ("434","Stunky","160","121","90");
    ("435","Skuntank","230","184","132");
    ("436","Bronzor","149","43","154");
    ("437","Bronzong","167","161","213");
    ("438","Bonsly","137","124","133");
    ("439","Mime Jr.","85","125","142");
    ("440","Happiny","225","25","77");
    ("441","Chatot","183","183","91");
    ("442","Spiritomb","137","169","199");
    ("443","Gible","151","124","84");
    ("444","Gabite","169","172","125");
    ("445","Garchomp","239","261","193");
    ("446","Munchlax","286","137","117");
    ("447","Riolu","120","127","78");
    ("448","Lucario","172","236","144");
    ("449","Hippopotas","169","124","118");
    ("450","Hippowdon","239","201","191");
    ("451","Skorupi","120","93","151");
    ("452","Drapion","172","180","202");
    ("453","Croagunk","134","116","76");
    ("454","Toxicroak","195","211","133");
    ("455","Carnivine","179","187","136");
    ("456","Finneon","135","96","116");
    ("457","Lumineon","170","142","170");
    ("458","Mantyke","128","105","179");
    ("459","Snover","155","115","105");
    ("460","Abomasnow","207","178","158");
    ("461","Weavile","172","243","171");
    ("462","Magnezone","172","238","205");
    ("463","Lickilicky","242","161","181");
    ("464","Rhyperior","251","241","190");
    ("465","Tangrowth","225","207","184");
    ("466","Electivire","181","249","163");
    ("467","Magmortar","181","247","172");
    ("468","Togekiss","198","225","217");
    ("469","Yanmega","200","231","156");
    ("470","Leafeon","163","216","219");
    ("471","Glaceon","163","238","205");
    ("472","Gliscor","181","185","222");
    ("473","Mamoswine","242","247","146");
    ("474","Porygon-Z","198","264","150");
    ("475","Gallade","169","237","195");
    ("476","Probopass","155","135","275");
    ("477","Dusknoir","128","180","254");
    ("478","Froslass","172","171","150");
    ("479","Rotom","137","185","159");
    ("479F","Rotom (Fan)","137","204","219");
    ("479R","Rotom (Frost)","137","204","219");
    ("479O","Rotom (Heat)","137","204","219");
    ("479L","Rotom (Mow)","137","204","219");
    ("479W","Rotom (Wash)","137","204","219");
    ("480","Uxie","181","156","270");
    ("481","Mesprit","190","212","212");
    ("482","Azelf","181","270","151");
    ("483","Dialga","205","275","211");
    ("484","Palkia","189","280","215");
    ("485","Heatran","209","251","213");
    ("486","Regigigas","221","287","210");
    ("487","Giratina","284","187","225");
    ("487O","Giratina (Origin)","284","225","187");
    ("488","Cresselia","260","152","258");
    ("489","Phione","190","162","162");
    ("490","Manaphy","225","210","210");
    ("491","Darkrai","172","285","198");
    ("492","Shaymin (Land)","225","210","210");
    ("492S","Shaymin (Sky)","225","261","166");
    ("493","Arceus","237","238","238");
    ("494","Victini","225","210","210");
    ("495","Snivy","128","88","107");
    ("496","Servine","155","122","152");
    ("497","Serperior","181","161","204");
    ("498","Tepig","163","115","85");
    ("499","Pignite","207","173","106");
    ("500","Emboar","242","235","127");
    ("501","Oshawott","146","117","85");
    ("502","Dewott","181","159","116");
    ("503","Samurott","216","212","157");
    ("504","Patrat","128","98","73");
    ("505","Watchog","155","165","139");
    ("506","Lillipup","128","107","86");
    ("507","Herdier","163","145","126");
    ("508","Stoutland","198","206","182");
    ("509","Purrloin","121","98","73");
    ("510","Liepard","162","187","106");
    ("511","Pansage","137","104","94");
    ("512","Simisage","181","206","133");
    ("513","Pansear","137","104","94");
    ("514","Simisear","181","206","133");
    ("515","Panpour","137","104","94");
    ("516","Simipour","181","206","133");
    ("517","Munna","183","111","92");
    ("518","Musharna","253","183","166");
    ("519","Pidove","137","98","80");
    ("520","Tranquill","158","144","107");
    ("521","Unfezant","190","226","146");
    ("522","Blitzle","128","118","64");
    ("523","Zebstrika","181","211","136");
    ("524","Roggenrola","146","121","110");
    ("525","Boldore","172","174","143");
    ("526","Gigalith","198","226","201");
    ("527","Woobat","163","107","85");
    ("528","Swoobat","167","161","119");
    ("529","Drilbur","155","154","85");
    ("530","Excadrill","242","255","129");
    ("531","Audino","230","114","163");
    ("532","Timburr","181","134","87");
    ("533","Gurdurr","198","180","134");
    ("534","Conkeldurr","233","243","158");
    ("535","Tympole","137","98","78");
    ("536","Palpitoad","181","128","109");
    ("537","Seismitoad","233","188","150");
    ("538","Throh","260","172","160");
    ("539","Sawk","181","231","153");
    ("540","Sewaddle","128","96","124");
    ("541","Swadloon","146","115","162");
    ("542","Leavanny","181","205","165");
    ("543","Venipede","102","83","99");
    ("544","Whirlipede","120","100","173");
    ("545","Scolipede","155","203","175");
    ("546","Cottonee","120","71","111");
    ("547","Whimsicott","155","164","176");
    ("548","Petilil","128","119","91");
    ("549","Lilligant","172","214","155");
    ("550","Basculin (Red)","172","189","129");
    ("550B","Basculin (Blue)","172","189","129");
    ("551","Sandile","137","132","69");
    ("552","Krokorok","155","155","90");
    ("553","Krookodile","216","229","158");
    ("554","Darumaka","172","153","86");
    ("555","Darmanitan","233","263","114");
    ("555Z","Darmanitan (Zen)","233","243","202");
    ("556","Maractus","181","201","130");
    ("557","Dwebble","137","118","128");
    ("558","Crustle","172","188","200");
    ("559","Scraggy","137","132","132");
    ("560","Scrafty","163","163","222");
    ("561","Sigilyph","176","204","167");
    ("562","Yamask","116","95","141");
    ("563","Cofagrigus","151","163","237");
    ("564","Tirtouga","144","134","146");
    ("565","Carracosta","179","192","197");
    ("566","Archen","146","213","89");
    ("567","Archeops","181","292","139");
    ("568","Trubbish","137","96","122");
    ("569","Garbodor","190","181","164");
    ("570","Zorua","120","153","78");
    ("571","Zoroark","155","250","127");
    ("572","Minccino","146","98","80");
    ("573","Cinccino","181","198","130");
    ("574","Gothita","128","98","112");
    ("575","Gothorita","155","137","153");
    ("576","Gothitelle","172","176","205");
    ("577","Solosis","128","170","83");
    ("578","Duosion","163","208","103");
    ("579","Reuniclus","242","214","148");
    ("580","Ducklett","158","84","96");
    ("581","Swanna","181","182","132");
    ("582","Vanillite","113","118","106");
    ("583","Vanillish","139","151","138");
    ("584","Vanilluxe","174","218","184");
    ("585","Deerling","155","115","100");
    ("586","Sawsbuck","190","198","146");
    ("587","Emolga","146","158","127");
    ("588","Karrablast","137","137","87");
    ("589","Escavalier","172","223","187");
    ("590","Foongus","170","97","91");
    ("591","Amoonguss","249","155","139");
    ("592","Frillish","146","115","134");
    ("593","Jellicent","225","159","178");
    ("594","Alomomola","338","138","131");
    ("595","Joltik","137","110","98");
    ("596","Galvantula","172","201","128");
    ("597","Ferroseed","127","82","155");
    ("598","Ferrothorn","179","158","223");
    ("599","Klink","120","98","121");
    ("600","Klang","155","150","174");
    ("601","Klinklang","155","199","214");
    ("602","Tynamo","111","105","78");
    ("603","Eelektrik","163","156","130");
    ("604","Eelektross","198","217","152");
    ("605","Elgyem","146","148","100");
    ("606","Beheeyem","181","221","163");
    ("607","Litwick","137","108","98");
    ("608","Lampent","155","169","115");
    ("609","Chandelure","155","271","182");
    ("610","Axew","130","154","101");
    ("611","Fraxure","165","212","123");
    ("612","Haxorus","183","284","172");
    ("613","Cubchoo","146","128","74");
    ("614","Beartic","216","233","152");
    ("615","Cryogonal","190","190","218");
    ("616","Shelmet","137","72","140");
    ("617","Accelgor","190","220","120");
    ("618","Stunfisk","240","144","171");
    ("619","Mienfoo","128","160","98");
    ("620","Mienshao","163","258","127");
    ("621","Druddigon","184","213","170");
    ("622","Golett","153","127","92");
    ("623","Golurk","205","222","154");
    ("624","Pawniard","128","154","114");
    ("625","Bisharp","163","232","176");
    ("626","Bouffalant","216","195","182");
    ("627","Rufflet","172","150","97");
    ("628","Braviary","225","232","152");
    ("629","Vullaby","172","105","139");
    ("630","Mandibuzz","242","129","205");
    ("631","Heatmor","198","204","129");
    ("632","Durant","151","217","188");
    ("633","Deino","141","116","93");
    ("634","Zweilous","176","159","135");
    ("635","Hydreigon","211","256","188");
    ("636","Larvesta","146","156","107");
    ("637","Volcarona","198","264","189");
    ("638","Cobalion","209","192","229");
    ("639","Terrakion","209","260","192");
    ("640","Virizion","209","192","229");
    ("641","Tornadus (Incarnate)","188","266","164");
    ("641T","Tornadus (Therian)","188","238","189");
    ("642","Thundurus (Incarnate)","188","266","164");
    ("642T","Thundurus (Therian)","188","295","161");
    ("643","Reshiram","205","275","211");
    ("644","Zekrom","205","275","211");
    ("645","Landorus (Incarnate)","205","261","182");
    ("645T","Landorus (Therian)","205","289","179");
    ("646","Kyurem","245","246","170");
    ("646W","Kyurem (White)","245","310","183");
    ("646B","Kyurem (Black)","245","310","183");
    ("647","Keldeo","209","260","192");
    ("647R","Keldeo (Resolute)","209","260","192");
    ("648","Meloetta (Aria)","225","250","225");
    ("648P","Meloetta (Pirouette)","225","269","188");
    ("808","Meltan","130","118","99");
    ("809","Melmetal","264","226","190")|]

//Level as int, and then true if half level above
//Level 36,true) is represented as (36,true)
type level = (int*bool)

let cpms : (level*float) array =
    [|((1,false),0.094);
    ((1,true),0.1351374318);
    ((2,false),0.16639787);
    ((2,true),0.192650919);
    ((3,false),0.21573247);
    ((3,true),0.2365726613);
    ((4,false),0.25572005);
    ((4,true),0.2735303812);
    ((5,false),0.29024988);
    ((5,true),0.3060573775);
    ((6,false),0.3210876);
    ((6,true),0.3354450362);
    ((7,false),0.34921268);
    ((7,true),0.3624577511);
    ((8,false),0.3752356);
    ((8,true),0.387592416);
    ((9,false),0.39956728);
    ((9,true),0.4111935514);
    ((10,false),0.4225);
    ((10,true),0.4329264091);
    ((11,false),0.44310755);
    ((11,true),0.4530599591);
    ((12,false),0.4627984);
    ((12,true),0.472336093);
    ((13,false),0.48168495);
    ((13,true),0.4908558003);
    ((14,false),0.49985844);
    ((14,true),0.508701765);
    ((15,false),0.51739395);
    ((15,true),0.5259425113);
    ((16,false),0.5343543);
    ((16,true),0.5426357375);
    ((17,false),0.5507927);
    ((17,true),0.5588305862);
    ((18,false),0.5667545);
    ((18,true),0.5745691333);
    ((19,false),0.5822789);
    ((19,true),0.5898879072);
    ((20,false),0.5974);
    ((20,true),0.6048236651);
    ((21,false),0.6121573);
    ((21,true),0.6194041216);
    ((22,false),0.6265671);
    ((22,true),0.6336491432);
    ((23,false),0.64065295);
    ((23,true),0.6475809666);
    ((24,false),0.65443563);
    ((24,true),0.6612192524);
    ((25,false),0.667934);
    ((25,true),0.6745818959);
    ((26,false),0.6811649);
    ((26,true),0.6876849038);
    ((27,false),0.69414365);
    ((27,true),0.70054287);
    ((28,false),0.7068842);
    ((28,true),0.7131691091);
    ((29,false),0.7193991);
    ((29,true),0.7255756136);
    ((30,false),0.7317);
    ((30,true),0.7347410093);
    ((31,false),0.7377695);
    ((31,true),0.7407855938);
    ((32,false),0.74378943);
    ((32,true),0.7467812109);
    ((33,false),0.74976104);
    ((33,true),0.7527290867);
    ((34,false),0.7556855);
    ((34,true),0.7586303683);
    ((35,false),0.76156384);
    ((35,true),0.7644860647);
    ((36,false),0.76739717);
    ((36,true),0.7702972656);
    ((37,false),0.7731865);
    ((37,true),0.7760649616);
    ((38,false),0.77893275);
    ((38,true),0.7817900548);
    ((39,false),0.784637);
    ((39,true),0.7874736075);
    ((40,false),0.7903);
    ((40,true),0.7928039467);
    ((41,false),0.79530001);
    ((41,true),0.797803922);
    ((42,false),0.8003);
    ((42,true),0.8004150083);
    ((43,false),0.8053);
    ((43,true),0.8054298091);
    ((44,false),0.81029999);
    ((44,true),0.8128038347);
    ((45,false),0.81529999)|]


(*
let Level2CpM (level) =
    let intLevel =
        if 
    let truncLevel =
        if level < 10 then 1,10
        elif level = 10 then 1,20
        elif level < 20 then 10,20
        elif level = 30 then 20,40
        elif level < 40 then 30,40
        elif level = 40 then 30,45
        else 40,45
    let CpM_down = 
        match fst truncLevel with
        | 1 -> 0.094
        | 10 -> 0.4225
        | 20 -> 0.5974
        | 30 -> 0.7317
        | 40 -> 0.7903
    let CpM_up = 
        match snd truncLevel with
        | 10 -> 0.4225
        | 20 -> 0.5974
        | 30 -> 0.7317
        | 40 -> 0.7903
        | 45 -> 0.8153
    CpM_down, CpM_up
    //(CpM_n^2 - CpM_1^2) / (level_n - level_1) = (CpM_2^2 - CpM_1^2) / (level_2 - level_1)
*)

let Level2CpM (level: level) =
    let halflevel = if snd level then 1 else 0
    let i = 2*(fst level) + halflevel - 2
    snd cpms.[i]

let Cp (atk) (def) (hp) (cpm) : int =
    int ((atk * sqrt(def) * sqrt(hp) * (cpm ** 2.0)) / 10.0)

let RealStat (basestat) (iv) (level: level) : float =
    float (basestat + iv) * Level2CpM level

let Level (atk) (def) (hp) (cp) =
    ()

//CP*Level*Atk*Def*HP*Statproduct
type stats = (int*level*float*float*float*float)

let Calculate (id: int) : (stats[][][] * stats[][][])  =
    let mutable level : level = (1,false)
    let (_,_,strHP,strAtk,strDef) = basestats.[id]
    let baseHP, baseAtk, baseDef = int strHP, int strAtk, int strDef
    let glData = Array.create 16 (Array.create 16 (Array.create 16 (0,level,0.0,0.0,0.0,0.0)))
    let ulData = Array.create 16 (Array.create 16 (Array.create 16 (0,level,0.0,0.0,0.0,0.0)))
    for atkIV = 0 to 15 do
        for defIV = 0 to 15 do
            for hpIV = 0 to 15 do
                level <- (1,false)
                let mutable isCalcing = true
                //(cp,level,realAtk,realDef,realHP,statProduct)
                let mutable glStats = (0,level,0.0,0.0,0.0,0.0)
                let mutable ulStats = (0,level,0.0,0.0,0.0,0.0)
                while isCalcing do
                    let realAtk = RealStat baseAtk atkIV level
                    let realDef = RealStat baseDef defIV level
                    let realHP =  float (int(RealStat baseHP hpIV level))
                    let totAtk = float (baseAtk + atkIV)
                    let totDef = float (baseDef + defIV)
                    let totHP = float(baseHP + hpIV)
                    let cpm = Level2CpM level
                    let cp = Cp totAtk totDef totHP cpm
                    let statProduct = realAtk * realDef * realHP
                    if cp <= 1500 then
                        glStats <- (cp,level,realAtk,realDef,realHP,statProduct)
                        if level = (45,false) then
                            isCalcing <- false
                        else level <-
                            if snd level then (fst level + 1, false)
                            else (fst level, true)
                    elif cp <= 2500 then
                        ulStats <- (cp,level,realAtk,realDef,realHP,statProduct)
                        if level = (45,false) then
                            isCalcing <- false
                        else level <-
                            if snd level then (fst level + 1, false)
                            else (fst level, true)
                    else
                        isCalcing <- false
                //Save data
                //printfn "%i/%i/%i: GL(%A) UL(%A)" atkIV defIV hpIV glStats ulStats
                glData.[atkIV].[defIV].[hpIV] <- glStats
                ulData.[atkIV].[defIV].[hpIV] <- ulStats
                ()
    (ulData, glData)


let WriteFile (id: int) =
    let path = string id + ".js"
    let fileRef = System.IO.File.CreateText path
    //Write stuff
    fileRef.Write "var ivspread = ["

    Calculate id

    fileRef.Close ()

let test = Level2CpM (45,false)
printfn "%A" test
let test2 = Calculate 266
let gltest = fst test2
let ultest = snd test2
printfn "%A" fst test2.[15].[15].[15]
//WriteFile 2