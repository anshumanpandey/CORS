-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 22, 2019 at 11:16 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `med`
--

-- --------------------------------------------------------

--
-- Table structure for table `t_address`
--

CREATE TABLE `t_address` (
  `idAddress` int(11) NOT NULL,
  `addNameOnLetterBox` varchar(150) DEFAULT NULL,
  `addAddress` varchar(150) DEFAULT NULL,
  `addNumber` int(11) DEFAULT NULL,
  `addZipcode` varchar(10) DEFAULT NULL,
  `addState` varchar(50) DEFAULT NULL,
  `idxCities` int(11) DEFAULT NULL,
  `fkCountry` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_address`
--

INSERT INTO `t_address` (`idAddress`, `addNameOnLetterBox`, `addAddress`, `addNumber`, `addZipcode`, `addState`, `idxCities`, `fkCountry`) VALUES
(1, 'Gian\'s name', 'Cramerstrasse, 704', 0, '6404', '', 1, 0),
(2, 'Valentin\'s name', 'Jucheggstrasse, 331', 0, '1954', '', 3, 0),
(3, 'Adrian\'s name', 'Johannastrasse, 91', 0, '5184', '', 9, 0),
(4, 'Lukas\'s name', 'Siriusstrasse, 164', 0, '1732', '', 3, 0),
(5, 'Valentin\'s name', 'Im Eisernen Zeit, 466', 0, '4730', '', 17, 0),
(6, 'Levi\'s name', 'Herman-Greulich-Strasse, 331', 0, '4202', '', 18, 0),
(7, 'Jason\'s name', 'Sonnenberghölzliweg, 375', 0, '9881', '', 15, 0),
(8, 'Hugo\'s name', 'Freigutstrasse, 294', 0, '9081', '', 2, 0),
(9, 'Lucas\'s name', 'Imbisbühlsteig, 817', 0, '5072', '', 2, 0),
(10, 'Luis\'s name', 'Püntstrasse, 166', 0, '8065', '', 16, 0),
(11, 'Laurin\'s name', 'Buhnrain, 959', 0, '3832', '', 6, 0),
(12, 'Joshua\'s name', 'Zurlindenstrasse, 80', 0, '3890', '', 6, 0),
(13, 'Manuel\'s name', 'Distelweg, 730', 0, '4524', '', 15, 0),
(14, 'Luis\'s name', 'St. Peterstrasse, 680', 0, '4326', '', 6, 0),
(15, 'Alex\'s name', 'Angelikaweg, 495', 0, '4656', '', 17, 0),
(16, 'Fabio\'s name', 'Feusisbergli, 112', 0, '6074', '', 2, 0),
(17, 'Adam\'s name', 'Begonienstrasse, 42', 0, '3827', '', 16, 0),
(18, 'Alexander\'s name', 'Owenweg, 198', 0, '6423', '', 5, 0),
(19, 'Fabian\'s name', 'Schmidgasse, 301', 0, '1581', '', 3, 0),
(20, 'Lars\'s name', 'Schiffbauplatz, 970', 0, '1247', '', 10, 0),
(21, 'Linus\'s name', 'Ferdinand-Hodler-Strasse, 848', 0, '7670', '', 15, 0),
(22, 'Ryan\'s name', 'Frauentalweg, 765', 0, '6124', '', 15, 0),
(23, 'Nathan\'s name', 'Waidbergweg, 411', 0, '9169', '', 18, 0),
(24, 'Luca\'s name', 'Füsslistrasse, 501', 0, '2939', '', 16, 0),
(25, 'Nolan\'s name', 'Maienstrasse, 438', 0, '9324', '', 11, 0),
(26, 'David\'s name', 'Am Sägertenbach, 14', 0, '9024', '', 10, 0),
(27, 'Timo\'s name', 'Kiefernweg, 120', 0, '6829', '', 5, 0),
(28, 'David\'s name', 'Algierstrasse, 910', 0, '4612', '', 16, 0),
(29, 'Elias\'s name', 'Beatenplatz, 32', 0, '2686', '', 11, 0),
(30, 'Manuel\'s name', 'Renggerstrasse, 481', 0, '1168', '', 1, 0),
(31, 'Andrin\'s name', 'Arosastrasse, 198', 0, '1909', '', 16, 0),
(32, 'Nino\'s name', 'Werdinsel, 400', 0, '3337', '', 19, 0),
(33, 'Ajan\'s name', 'Sandstrasse, 135', 0, '3010', '', 5, 0),
(34, 'Ben\'s name', 'Weitlingweg, 357', 0, '2463', '', 11, 0),
(35, 'Nolan\'s name', 'Waldgartenweg, 29', 0, '4980', '', 12, 0),
(36, 'Louis\'s name', 'Distelweg, 188', 0, '9753', '', 11, 0),
(37, 'Nathan\'s name', 'Badweg, 738', 0, '4598', '', 16, 0),
(38, 'Andrin\'s name', 'Burgstrasse, 75', 0, '1163', '', 10, 0),
(39, 'Paul\'s name', 'Herrligstrasse, 502', 0, '2408', '', 6, 0),
(40, 'Kevin\'s name', 'Hegarstrasse, 8', 0, '8105', '', 11, 0),
(41, 'Nino\'s name', 'Mürtschenstrasse, 711', 0, '9574', '', 10, 0),
(42, 'Luca\'s name', 'Marie-Heim-Vögtlin-Weg, 32', 0, '6358', '', 7, 0),
(43, 'Elia\'s name', 'Luegete, 111', 0, '1456', '', 16, 0),
(44, 'Arthur\'s name', 'Im Hummel, 164', 0, '4649', '', 20, 0),
(45, 'Nicolas\'s name', 'In der Wässeri, 517', 0, '1545', '', 14, 0),
(46, 'Lucas\'s name', 'Max-Högger-Strasse, 226', 0, '8700', '', 4, 0),
(47, 'Nico\'s name', 'Grossrieglenweg, 408', 0, '4896', '', 4, 0),
(48, 'Julian\'s name', 'Turnersteig, 568', 0, '6064', '', 11, 0),
(49, 'Ethan\'s name', 'Bergstrasse, 442', 0, '9689', '', 10, 0),
(50, 'Lio\'s name', 'Stettbacherrain, 210', 0, '6366', '', 19, 0),
(51, 'Louis\'s name', 'Spiserstrasse, 103', 0, '2277', '', 9, 0),
(52, 'Luan\'s name', 'Nüschelersteg, 756', 0, '3340', '', 20, 0),
(53, 'Paul\'s name', 'Katzenrütifussweg, 363', 0, '7868', '', 8, 0),
(54, 'Elia\'s name', 'Fronwaldweg, 687', 0, '9398', '', 2, 0),
(55, 'Leo\'s name', 'Dufourstrasse, 283', 0, '9666', '', 12, 0),
(56, 'Dylan\'s name', 'Zehntenhausstrasse, 761', 0, '7337', '', 16, 0),
(57, 'Jan\'s name', 'Oskar-Bider-Strasse, 631', 0, '1989', '', 8, 0),
(58, 'Luan\'s name', 'Badstrasse, 843', 0, '7827', '', 1, 0),
(59, 'Hugo\'s name', 'Nüschelersteg, 137', 0, '2266', '', 3, 0),
(60, 'Lio\'s name', 'Quaibrücke, 145', 0, '2534', '', 11, 0),
(61, 'Loris\'s name', 'Brunnackerweg, 77', 0, '2397', '', 19, 0),
(62, 'Adrian\'s name', 'Massholderweg, 501', 0, '2028', '', 1, 0),
(63, 'Mattia\'s name', 'Hertensteinstrasse, 937', 0, '1375', '', 10, 0),
(64, 'Leo\'s name', 'Lerchenstrasse, 201', 0, '9736', '', 20, 0),
(65, 'Rafael\'s name', 'Jupiterstrasse, 486', 0, '5724', '', 15, 0),
(66, 'Leandro\'s name', 'Rudolf-Hägi-Strasse, 66', 0, '2956', '', 6, 0),
(67, 'Nico\'s name', 'Hausäcker, 986', 0, '8239', '', 7, 0),
(68, 'Max\'s name', 'Alte Mühlackerstrasse, 471', 0, '4848', '', 8, 0),
(69, 'Nino\'s name', 'Schärenmoosstrasse, 122', 0, '4635', '', 1, 0),
(70, 'Elia\'s name', 'Riedenhaldensteig, 97', 0, '2119', '', 6, 0),
(71, 'Moritz\'s name', 'Sagentobelstrasse, 228', 0, '8666', '', 20, 0),
(72, 'Nico\'s name', 'Lindenplatz, 604', 0, '5177', '', 12, 0),
(73, 'Nino\'s name', 'Bubenbergstrasse, 42', 0, '7488', '', 16, 0),
(74, 'Luca\'s name', 'Fellenbergweg, 764', 0, '3400', '', 15, 0),
(75, 'Julian\'s name', 'Im Schaber, 761', 0, '8782', '', 13, 0),
(76, 'Adam\'s name', 'Konradstrasse, 896', 0, '7019', '', 5, 0),
(77, 'Alex\'s name', 'Berninaplatz, 798', 0, '2182', '', 11, 0),
(78, 'Manuel\'s name', 'Entlisbergstrasse, 604', 0, '8938', '', 18, 0),
(79, 'Felix\'s name', 'Im Jungen Berg, 426', 0, '8762', '', 8, 0),
(80, 'Jonas\'s name', 'Bachwiesenstrasse, 582', 0, '4502', '', 16, 0),
(81, 'Valentin\'s name', 'Gasometerstrasse, 741', 0, '8558', '', 3, 0),
(82, 'Levin\'s name', 'Kappelergasse, 718', 0, '3122', '', 7, 0),
(83, 'Adrian\'s name', 'Denzlerstrasse, 453', 0, '1115', '', 6, 0),
(84, 'Simon\'s name', 'Morgenweg, 675', 0, '1017', '', 6, 0),
(85, 'Lio\'s name', 'Waldhausstrasse, 200', 0, '6925', '', 5, 0),
(86, 'Nolan\'s name', 'Dunkelhölzlistrasse, 926', 0, '3987', '', 2, 0),
(87, 'Kilian\'s name', 'Hermetschloobrücke, 573', 0, '6566', '', 13, 0),
(88, 'Lean\'s name', 'Kämbelgasse, 287', 0, '6610', '', 17, 0),
(89, 'Maximilian\'s name', 'Gotthardstrasse, 808', 0, '5545', '', 18, 0),
(90, 'Dario\'s name', 'Hochstrasse, 758', 0, '6197', '', 12, 0),
(91, 'Adam\'s name', 'Chorherrenweg, 275', 0, '5131', '', 10, 0),
(92, 'Emil\'s name', 'Staudenbühlstrasse, 111', 0, '7884', '', 8, 0),
(93, 'Maxime\'s name', 'Höfliweg, 843', 0, '2240', '', 10, 0),
(94, 'Joshua\'s name', 'Rückgasse, 915', 0, '8051', '', 7, 0),
(95, 'Arthur\'s name', 'Hellmutstrasse, 825', 0, '8647', '', 2, 0),
(96, 'Kevin\'s name', 'Kasinostrasse, 882', 0, '3639', '', 12, 0),
(97, 'Valentin\'s name', 'Schaffhauserstrasse, 821', 0, '6857', '', 17, 0),
(98, 'Livio\'s name', 'Wipkingerplatz, 191', 0, '6160', '', 15, 0),
(99, 'Diego\'s name', 'Buchfinkenstrasse, 755', 0, '6494', '', 13, 0),
(100, 'Lenny\'s name', 'Drusbergstrasse, 676', 0, '8420', '', 8, 0),
(101, 'Robin\'s name', 'Känzeliweg, 958', 0, '9219', '', 3, 0),
(102, 'Noe\'s name', 'Siriusstrasse, 837', 0, '4414', '', 14, 0),
(103, 'Lorik\'s name', 'Bühlwiesenstrasse, 968', 0, '7532', '', 5, 0),
(104, 'Noe\'s name', 'Studackerstrasse, 804', 0, '3125', '', 20, 0),
(105, 'Fabio\'s name', 'Mascha-Kaléko-Weg, 137', 0, '6638', '', 9, 0),
(106, 'Gabriel\'s name', 'Holbrigstrasse, 945', 0, '2600', '', 20, 0),
(107, 'Diego\'s name', 'Römergasse, 96', 0, '5556', '', 5, 0),
(108, 'Loris\'s name', 'Meier-Bosshard-Strasse, 94', 0, '5789', '', 17, 0),
(109, 'Nathan\'s name', 'Kirchenackerweg, 598', 0, '8803', '', 9, 0),
(110, 'Alexander\'s name', 'Baslerstrasse, 700', 0, '1453', '', 7, 0),
(111, 'Levi\'s name', 'Joachim-Hefti-Weg, 437', 0, '7349', '', 15, 0),
(112, 'Julian\'s name', 'Eschergutweg, 477', 0, '4634', '', 16, 0),
(113, 'Leon\'s name', 'Pflugstrasse, 602', 0, '1971', '', 3, 0),
(114, 'Rafael\'s name', 'Gertrud-Kurz-Strasse, 230', 0, '5486', '', 3, 0),
(115, 'Leano\'s name', 'Juchweg, 853', 0, '1962', '', 18, 0),
(116, 'Tim\'s name', 'Hofhölzliweg, 729', 0, '7272', '', 7, 0),
(117, 'Emil\'s name', 'Schäracher, 576', 0, '3863', '', 15, 0),
(118, 'Luan\'s name', 'Marderstrasse, 962', 0, '4678', '', 7, 0),
(119, 'Timo\'s name', 'Rudolf-Brun-Brücke, 124', 0, '3053', '', 13, 0),
(120, 'Alex\'s name', 'Eisenbahnerstrasse, 265', 0, '5177', '', 3, 0),
(121, 'Vigler\'s name', 'Paul-Grüninger-Weg, 250', 0, '9354', '', 16, 0),
(122, 'La Prairie1\'s name', 'Stadelhoferstrasse, 759', 0, '7191', '', 2, 0),
(123, 'La Prairie2\'s name', 'Guggerweg, 325', 0, '5711', '', 17, 0),
(124, 'La Prairie3\'s name', 'Zeppelinstrasse, 456', 0, '5315', '', 16, 0),
(125, 'La Prairie4\'s name', 'Ernst-Zöbeli-Strasse, 533', 0, '2902', '', 12, 0),
(126, 'La Prairie5\'s name', 'Bruggerweg, 1', 0, '9004', '', 10, 0),
(127, 'La Prairie6\'s name', 'Schiffländeplatz, 99', 0, '7589', '', 6, 0),
(128, 'Aquamed1\'s name', 'Hechtplatz, 186', 0, '8926', '', 3, 0),
(129, 'Aquamed2\'s name', 'Remisenstrasse, 651', 0, '2829', '', 11, 0),
(130, 'Aquamed3\'s name', 'Germaniastrasse, 759', 0, '7676', '', 10, 0),
(131, 'Aquamed4\'s name', 'Landoltstrasse, 300', 0, '2295', '', 5, 0),
(132, 'Aquamed5\'s name', 'In den Rütenen, 685', 0, '2883', '', 19, 0),
(133, 'Aquamed6\'s name', 'Möhrlistrasse, 368', 0, '4048', '', 5, 0),
(134, 'Providence1\'s name', 'Waserstrasse, 139', 0, '6988', '', 16, 0),
(135, 'Providence2\'s name', 'Ferdinand-Hodler-Strasse, 786', 0, '5425', '', 9, 0),
(136, 'Providence3\'s name', 'Lachenacker, 136', 0, '5718', '', 18, 0),
(137, 'Providence4\'s name', 'Töbeliweg, 634', 0, '7358', '', 5, 0),
(138, 'Providence5\'s name', 'Schanzengasse, 136', 0, '3719', '', 4, 0),
(139, 'Providence6\'s name', 'Schlösslistrasse, 112', 0, '5040', '', 4, 0),
(140, 'Clinique Suisse Montreux1\'s name', 'Josefstrasse, 341', 0, '1966', '', 4, 0),
(141, 'Clinique Suisse Montreux2\'s name', 'Kempfhofweg, 930', 0, '6649', '', 13, 0),
(142, 'Clinique Suisse Montreux3\'s name', 'Stodolastrasse, 483', 0, '1952', '', 11, 0),
(143, 'Clinique Suisse Montreux4\'s name', 'Ruhestrasse, 509', 0, '3726', '', 13, 0),
(144, 'Clinique Suisse Montreux5\'s name', 'Margaretenweg, 531', 0, '6051', '', 1, 0),
(145, 'Clinique Suisse Montreux6\'s name', 'Röslistrasse, 739', 0, '6368', '', 17, 0),
(146, 'CIC Riviera\'s name', 'Appenzellerstrasse, 505', 0, '9957', '', 5, 0),
(147, 'CIC Chablais\'s name', 'Waltersbachstrasse, 774', 0, '6551', '', 5, 0),
(148, 'ASMAV\'s name', 'Herrligstrasse, 698', 0, '3234', '', 16, 0),
(149, 'Clinique Cecil\'s name', 'Verena-Conzett-Strasse, 8', 0, '5570', '', 11, 0),
(150, 'Fondation de nant\'s name', 'Buchwiesenweg, 740', 0, '5624', '', 9, 0),
(151, 'GSMN\'s name', 'Im Kratz, 145', 0, '8842', '', 3, 0),
(152, 'Pharmacie 24\'s name', 'Saatlenzelg, 896', 0, '1350', '', 16, 0),
(153, 'Amavita Acacias\'s name', 'Arosastrasse, 549', 0, '1399', '', 9, 0),
(154, 'Amavita Cardinaux\'s name', 'Loogartenstrasse, 499', 0, '9437', '', 8, 0),
(155, 'Amavita Jura\'s name', 'Bläsistrasse, 808', 0, '1393', '', 12, 0),
(156, 'Champs Frechets\'s name', 'Am Luchsgraben, 516', 0, '5820', '', 13, 0),
(157, 'Pharmacie Cina\'s name', 'Seeblickstrasse, 844', 0, '7277', '', 15, 0),
(158, 'Pharmacie D\'Herborence\'s name', 'Wolfbachtobelweg, 294', 0, '3012', '', 14, 0),
(159, 'Pharmacie d\'Orsières\'s name', 'Löwensteg, 573', 0, '5429', '', 12, 0),
(160, 'Pharmacie de Clarens\'s name', 'Im Altried, 404', 0, '5566', '', 1, 0),
(161, 'Pharmacie de Cortot\'s name', 'Gerhardstrasse, 903', 0, '4070', '', 12, 0),
(162, 'Pharmacie de Florissant - Renens\'s name', 'Aprikosenstrasse, 912', 0, '1157', '', 6, 0),
(163, 'Pharmacie de l\'ile à Rolle\'s name', 'Winzerhalde, 662', 0, '9946', '', 20, 0),
(164, 'Pharmacie du Tilleul\'s name', 'Lebristweg, 363', 0, '7793', '', 10, 0),
(165, 'Pharmacie Saint-Léger\'s name', 'Panoramaweg, 655', 0, '8111', '', 15, 0),
(166, 'Pharmacie Populaire - Officine : Varembe\'s name', 'Gottfried-Keller-Strasse, 809', 0, '9369', '', 20, 0),
(167, 'Pharmacie Populaire - Officine : Trois-Chêne\'s name', 'Maneggpromenade, 466', 0, '2011', '', 18, 0),
(168, 'Pharmacie Chablais-Gare\'s name', 'Billoweg, 746', 0, '6974', '', 10, 0),
(169, 'Salveo\'s name', 'Maaghof, 966', 0, '1550', '', 3, 0),
(170, 'Pharmapro\'s name', 'Köllikerstrasse, 755', 0, '7191', '', 14, 0),
(171, 'Pharmacies de Garde à Martigny\'s name', 'Gwandensteig, 61', 0, '7602', '', 16, 0),
(172, 'AXA\'s name', 'Streulistrasse, 996', 0, '4325', '', 5, 0),
(173, 'CSS\'s name', 'Schaffhauserplatz, 823', 0, '9325', '', 12, 0),
(174, 'Groupe Mutuel Philos\'s name', 'Eggpromenade, 816', 0, '2830', '', 19, 0),
(175, 'General Lee\'s name', 'Obere Bläsistrasse, 429', 0, '7343', '', 13, 0),
(176, 'Assura\'s name', 'Bullingerplatz, 757', 0, '4957', '', 11, 0),
(177, 'SUVA\'s name', 'Hagenholzstrasse, 340', 0, '4411', '', 2, 0),
(178, 'Helsana\'s name', 'Baumschulweg, 904', 0, '4578', '', 17, 0),
(179, 'Concordia\'s name', 'Walcheplatz, 567', 0, '6384', '', 10, 0),
(180, 'Sanitas\'s name', 'Jacob-Burckhardt-Strasse, 800', 0, '8344', '', 18, 0),
(181, 'KPT/CPT Holding\'s name', 'Frankentalerstrasse, 641', 0, '5600', '', 19, 0),
(182, 'Wincare\'s name', 'Löwenstrasse, 244', 0, '8086', '', 9, 0),
(183, 'Atupri\'s name', 'Brandschenkestrasse, 128', 0, '7544', '', 8, 0),
(184, 'ÖKK\'s name', 'Dachslernweg, 809', 0, '6853', '', 11, 0),
(185, 'EGK-Gesundheitskasse\'s name', 'Kraftstrasse, 383', 0, '7926', '', 12, 0),
(186, 'Sympany\'s name', 'Bächlerstrasse, 454', 0, '5628', '', 9, 0),
(187, 'Sansan Versicherungen\'s name', 'Hirschengasse, 103', 0, '5081', '', 18, 0),
(188, 'Agrisano\'s name', 'Stoffelstrasse, 515', 0, '9715', '', 5, 0),
(189, 'Avanex\'s name', 'Staudenbühlstrasse, 725', 0, '2789', '', 16, 0),
(190, 'Carena Schweiz\'s name', 'Holbrigstrasse, 689', 0, '9500', '', 19, 0),
(191, 'Fondation AMB\'s name', 'Rollengasse, 286', 0, '6910', '', 17, 0),
(192, 'Fondation Rive-Neuve\'s name', 'Maienweg, 75', 0, '1033', '', 15, 0),
(193, 'OMSV\'s name', 'Staudenbühlstrasse, 405', 0, '9077', '', 2, 0),
(194, 'ASI Section Vaud\'s name', 'Hüttisstrasse, 239', 0, '6699', '', 7, 0),
(195, 'ARLD\'s name', 'Kirchgasse, 522', 0, '2399', '', 2, 0),
(196, 'PhisioSwiss\'s name', 'Schulstrasse, 226', 0, '6861', '', 15, 0),
(197, 'SVMED\'s name', 'Heuelsteig, 290', 0, '5384', '', 11, 0),
(198, 'SVMD\'s name', 'Else-Lasker-Schüler-Weg, 153', 0, '9297', '', 9, 0),
(199, 'Dr Gapany\'s name', 'Räuberweg, 400', 0, '9666', '', 14, 0),
(200, 'Dr René Lysek\'s name', 'Wühre, 415', 0, '9431', '', 4, 0),
(201, 'AVADOL\'s name', 'Witikonerstrasse, 492', 0, '1316', '', 8, 0),
(202, 'AVSD\'s name', 'Europabrücke, 371', 0, '2162', '', 1, 0),
(203, 'AVADOL\'s name', 'Hardstrasse, 756', 0, '5834', '', 13, 0),
(204, 'PRENDPLACE\'s name', 'Weinbergstrasse, 795', 0, '6016', '', 20, 0),
(205, 'PSY VS\'s name', 'Räuberweg, 439', 0, '4842', '', 15, 0),
(206, 'IRO\'s name', 'Klosterholzweg, 194', 0, '5620', '', 5, 0),
(207, 'ASSAL\'s name', 'Luchsweg, 332', 0, '8315', '', 1, 0),
(208, 'CM Lignon\'s name', 'Eulenweg, 457', 0, '1654', '', 13, 0),
(209, 'CMS Magellan\'s name', 'Maneggstrasse, 708', 0, '7793', '', 2, 0),
(210, 'EMS Val Fleuri\'s name', 'Sternwartstrasse, 265', 0, '3674', '', 10, 0),
(211, 'Fondation Fénix\'s name', 'Aegertenweg, 31', 0, '3030', '', 1, 0),
(212, 'Alexander\'s name', 'Drahtschmidlisteig, 167', 0, '6491', '', 8, 0),
(213, 'Lorik\'s name', 'Lettenstrasse, 381', 0, '5337', '', 9, 0),
(214, 'Simon\'s name', 'Wildbachstrasse, 479', 0, '6752', '', 12, 0),
(215, 'Liam\'s name', 'Stöckengasse, 574', 0, '3468', '', 4, 0),
(216, 'Manuel\'s name', 'Pfingstweid, 871', 0, '9522', '', 11, 0),
(217, 'Jason\'s name', 'Langmattweg, 615', 0, '4316', '', 4, 0),
(218, 'Finn\'s name', 'Sihlstrasse, 461', 0, '2222', '', 1, 0),
(219, 'Aaron\'s name', 'Heimstrasse, 841', 0, '8571', '', 20, 0),
(220, 'Leo\'s name', 'Ankerstrasse, 838', 0, '5813', '', 4, 0),
(221, 'Leo\'s name', 'Stettbachweg, 42', 0, '1356', '', 1, 0),
(222, 'Ben\'s name', 'Am Wettingertobel, 951', 0, '1449', '', 17, 0),
(223, 'Andrin\'s name', 'Dammsteg, 435', 0, '5702', '', 18, 0),
(224, 'Lorenzo\'s name', 'Im Grund, 504', 0, '8609', '', 19, 0),
(225, 'Nicolas\'s name', 'Wolfgang-Pauli-Strasse, 606', 0, '5960', '', 12, 0),
(226, 'Adam\'s name', 'James-Joyce-Strasse, 127', 0, '5502', '', 16, 0),
(227, 'Timo\'s name', 'In Gassen, 542', 0, '7942', '', 19, 0),
(228, 'Maximilian\'s name', 'Südstrasse, 558', 0, '9696', '', 4, 0),
(229, 'Julian\'s name', 'Oberer Bodenweg, 679', 0, '3295', '', 2, 0),
(230, 'Nicolas\'s name', 'Susenbergstrasse, 607', 0, '1099', '', 7, 0),
(231, 'Alessandro\'s name', 'Imbisbühlweg, 151', 0, '5866', '', 7, 0),
(232, 'Simon\'s name', 'Holbrigstrasse, 765', 0, '2379', '', 13, 0),
(233, 'Luca\'s name', 'Banzwiesenstrasse, 227', 0, '5165', '', 2, 0),
(234, 'Daniel\'s name', 'Hegianwandweg, 23', 0, '1761', '', 16, 0),
(235, 'Timo\'s name', 'Ampèresteg, 753', 0, '3458', '', 18, 0),
(236, 'Dario\'s name', 'Maienburgweg, 648', 0, '1193', '', 10, 0),
(237, 'Lorik\'s name', 'Regulastrasse, 151', 0, '7086', '', 1, 0),
(238, 'Elias\'s name', 'Tuggenerstrasse, 341', 0, '2529', '', 7, 0),
(239, 'Hugo\'s name', 'Kornhausstrasse, 674', 0, '4178', '', 16, 0),
(240, 'Livio\'s name', 'Carl-Spitteler-Strasse, 814', 0, '9348', '', 13, 0),
(241, 'Nicolas\'s name', 'Ernst-Zöbeli-Strasse, 781', 0, '2336', '', 18, 0),
(242, 'Livio\'s name', 'Maagplatz, 413', 0, '1249', '', 6, 0),
(243, 'Noah\'s name', 'Wonnebergstrasse, 971', 0, '9039', '', 4, 0),
(244, 'Fabio\'s name', 'Farbhofstrasse, 349', 0, '1278', '', 3, 0),
(245, 'Nathan\'s name', 'Loorentorweg, 880', 0, '3850', '', 4, 0),
(246, 'Maximilian\'s name', 'Denzlerweg, 840', 0, '8814', '', 19, 0),
(247, 'Nicolas\'s name', 'Hermetschloobrücke, 643', 0, '4457', '', 13, 0),
(248, 'Leonardo\'s name', 'Riedmattstrasse, 595', 0, '2901', '', 8, 0),
(249, 'Jan\'s name', 'Forchstrasse, 145', 0, '8344', '', 18, 0),
(250, 'Max\'s name', 'Bernerstrasse Süd, 898', 0, '5006', '', 19, 0),
(251, 'Valentin\'s name', 'Schneebeliweg, 395', 0, '8878', '', 3, 0),
(252, 'Livio\'s name', 'Moosgutstrasse, 964', 0, '7443', '', 1, 0),
(253, 'Alex\'s name', 'Hans-Huber-Strasse, 203', 0, '4480', '', 14, 0),
(254, 'Felix\'s name', 'Laubiweg, 202', 0, '9319', '', 15, 0),
(255, 'Daniel\'s name', 'Gloriasteig, 446', 0, '2683', '', 4, 0),
(256, 'Damian\'s name', 'Goldbrunnenplatz, 565', 0, '5222', '', 17, 0),
(257, 'Fabio\'s name', 'Einsteinstrasse, 408', 0, '3403', '', 5, 0),
(258, 'Ethan\'s name', 'Wengistrasse, 841', 0, '2557', '', 2, 0),
(259, 'Manuel\'s name', 'Bachmattstrasse, 737', 0, '1025', '', 2, 0),
(260, 'Louis\'s name', 'Luchswiesenweg, 805', 0, '5032', '', 4, 0),
(261, 'Noah\'s name', 'Oetenbacherholz, 636', 0, '3663', '', 1, 0),
(262, 'Nils\'s name', 'Uetliberghalde, 403', 0, '3794', '', 6, 0),
(263, 'Robin\'s name', 'Herbstweg, 604', 0, '9866', '', 9, 0),
(264, 'Oliver\'s name', 'Ulmenweg, 249', 0, '5272', '', 16, 0),
(265, 'Mateo\'s name', 'Mittelbergsteig, 168', 0, '1643', '', 6, 0),
(266, 'Levi\'s name', 'Stapferstrasse, 957', 0, '8001', '', 19, 0),
(267, 'Julian\'s name', 'Kürbergstrasse, 940', 0, '8178', '', 7, 0),
(268, 'Thomas\'s name', 'Freudenbergstrasse, 465', 0, '9716', '', 9, 0),
(269, 'Timo\'s name', 'Maaghof, 843', 0, '1231', '', 2, 0),
(270, 'Timo\'s name', 'Rüdigerstrasse, 607', 0, '2021', '', 8, 0),
(271, 'Ben\'s name', 'Albert-Schneider-Weg, 612', 0, '6962', '', 19, 0),
(272, 'Paul\'s name', 'Hellrainweg, 904', 0, '7705', '', 5, 0),
(273, 'Kevin\'s name', 'Toblerstrasse, 705', 0, '7854', '', 16, 0),
(274, 'Elia\'s name', 'Max-Högger-Strasse, 743', 0, '2883', '', 7, 0),
(275, 'Laurin\'s name', 'Hirslanderstrasse, 349', 0, '8841', '', 4, 0),
(276, 'Lio\'s name', 'Sophie-Albrecht-Weg, 880', 0, '1039', '', 16, 0),
(277, 'Emil\'s name', 'Langwiesstrasse, 786', 0, '5667', '', 17, 0),
(278, 'Lars\'s name', 'Im Laubegg, 348', 0, '1571', '', 5, 0),
(279, 'Marco\'s name', 'Zimmerlistrasse, 388', 0, '6368', '', 20, 0),
(280, 'Dario\'s name', 'Redingstrasse, 180', 0, '2020', '', 14, 0),
(281, 'Kilian\'s name', 'Jägergasse, 513', 0, '2654', '', 19, 0),
(282, 'Matteo\'s name', 'Kettberg, 237', 0, '5056', '', 18, 0),
(283, 'Jason\'s name', 'Bellikersteig, 876', 0, '7181', '', 20, 0),
(284, 'Jan\'s name', 'Baalweg, 241', 0, '7722', '', 13, 0),
(285, 'Theo\'s name', 'Angererstrasse, 25', 0, '4087', '', 4, 0),
(286, 'Marco\'s name', 'Stauffacherstrasse, 336', 0, '7429', '', 10, 0),
(287, 'Joel\'s name', 'Bachtobelweg, 475', 0, '4810', '', 16, 0),
(288, 'Arthur\'s name', 'Steinbrüchelstrasse, 956', 0, '4915', '', 12, 0),
(289, 'Gian\'s name', 'Probusweg, 766', 0, '1068', '', 18, 0),
(290, 'Theo\'s name', 'Agleistrasse, 139', 0, '9969', '', 5, 0),
(291, 'Nolan\'s name', 'Weltistrasse, 174', 0, '8103', '', 6, 0),
(292, 'Adrian\'s name', 'Jenatschstrasse, 855', 0, '7954', '', 11, 0),
(293, 'Noah\'s name', 'Leutschenbachstrasse, 697', 0, '3639', '', 1, 0),
(294, 'Kilian\'s name', 'Toblerstrasse, 572', 0, '9760', '', 16, 0),
(295, 'Linus\'s name', 'Pilatusstrasse, 292', 0, '2168', '', 10, 0),
(296, 'Ethan\'s name', 'Burenweg, 730', 0, '9753', '', 19, 0),
(297, 'Valentin\'s name', 'Stephan-à-Porta-Weg, 638', 0, '6876', '', 13, 0),
(298, 'Tim\'s name', 'Arosastrasse, 190', 0, '8754', '', 17, 0),
(299, 'Mateo\'s name', 'Waldmeisterweg, 172', 0, '1923', '', 6, 0),
(300, 'Alex\'s name', 'Schmidgasse, 384', 0, '6556', '', 9, 0),
(301, 'Nevio\'s name', 'Bungertweg, 539', 0, '7307', '', 12, 0),
(302, 'Noel\'s name', 'Treichlerstrasse, 674', 0, '8666', '', 4, 0),
(303, 'Felix\'s name', 'Kleinstrasse, 611', 0, '5647', '', 1, 0),
(304, 'Lukas\'s name', 'Am Rank, 747', 0, '9036', '', 7, 0),
(305, 'Thomas\'s name', 'Paul-Grüninger-Weg, 715', 0, '5532', '', 12, 0),
(306, 'Leo\'s name', 'Schiffbauplatz, 536', 0, '5176', '', 17, 0),
(307, 'Diego\'s name', 'Tobelsteig, 243', 0, '4339', '', 4, 0),
(308, 'Maël\'s name', 'Schweizergasse, 187', 0, '9220', '', 10, 0),
(309, 'Kevin\'s name', 'Vulkanplatz, 20', 0, '5410', '', 17, 0),
(310, 'Adam\'s name', 'Kappenbühlweg, 873', 0, '9134', '', 5, 0),
(311, 'Jan\'s name', 'Kreuzplatz, 478', 0, '4924', '', 16, 0),
(312, 'Moritz\'s name', 'Binzmühlestrasse, 623', 0, '6236', '', 10, 0),
(313, 'Luca\'s name', 'Breitingerstrasse, 257', 0, '3252', '', 14, 0),
(314, 'Luca\'s name', 'Paul-Grüninger-Weg, 792', 0, '8885', '', 20, 0),
(315, 'Loris\'s name', 'Andreaspark, 769', 0, '9222', '', 14, 0),
(316, 'Matteo\'s name', 'Lochenweg, 811', 0, '5785', '', 1, 0),
(317, 'Alexander\'s name', 'Heinrich-Federer-Strasse, 71', 0, '3890', '', 19, 0),
(318, 'Nico\'s name', 'Nietengasse, 594', 0, '4411', '', 20, 0),
(319, 'Lian\'s name', 'Sihlamtsstrasse, 86', 0, '5167', '', 8, 0),
(320, 'Lionel\'s name', 'Norastrasse, 603', 0, '6416', '', 4, 0),
(321, 'David\'s name', 'Holzhofweg, 311', 0, '2690', '', 20, 0),
(322, 'Arthur\'s name', 'Im Wyl, 644', 0, '6229', '', 16, 0),
(323, 'Rafael\'s name', 'Salersteig, 661', 0, '6185', '', 2, 0),
(324, 'Finn\'s name', 'Emil-Rütti-Weg, 197', 0, '6353', '', 15, 0),
(325, 'Lionel\'s name', 'Schörlistrasse, 87', 0, '2114', '', 17, 0),
(326, 'Luca\'s name', 'Kürbergsteig, 432', 0, '7994', '', 4, 0),
(327, 'Levin\'s name', 'In Büngerten, 530', 0, '7954', '', 1, 0),
(328, 'Andrin\'s name', 'Kleinbühlstrasse, 61', 0, '3884', '', 6, 0),
(329, 'Timo\'s name', 'Kraftstrasse, 726', 0, '6423', '', 18, 0),
(330, 'Nino\'s name', 'Neudorfstrasse, 206', 0, '8483', '', 9, 0),
(331, 'Paul\'s name', 'Füsslistrasse, 265', 0, '9686', '', 20, 0),
(332, 'La Prairie1\'s name', 'Talacker, 717', 0, '2938', '', 11, 0),
(333, 'La Prairie2\'s name', 'Lux-Guyer-Weg, 759', 0, '9738', '', 4, 0),
(334, 'La Prairie3\'s name', 'Weineggstrasse, 562', 0, '7300', '', 19, 0),
(335, 'La Prairie4\'s name', 'Zollstrasse, 89', 0, '6452', '', 4, 0),
(336, 'La Prairie5\'s name', 'Ackermannstrasse, 156', 0, '7580', '', 6, 0),
(337, 'La Prairie6\'s name', 'Böcklinstrasse, 605', 0, '6940', '', 19, 0),
(338, 'Aquamed1\'s name', 'Neumünsterstrasse, 276', 0, '5924', '', 10, 0),
(339, 'Aquamed2\'s name', 'Drahtzugstrasse, 280', 0, '7550', '', 16, 0),
(340, 'Aquamed3\'s name', 'Rehgässchen, 493', 0, '2049', '', 10, 0),
(341, 'Aquamed4\'s name', 'Wannenweg, 671', 0, '9570', '', 19, 0),
(342, 'Aquamed5\'s name', 'Universitätstrasse, 926', 0, '2654', '', 13, 0),
(343, 'Aquamed6\'s name', 'Gässli, 928', 0, '6524', '', 11, 0),
(344, 'Providence1\'s name', 'Kronwiesenstrasse, 853', 0, '6483', '', 14, 0),
(345, 'Providence2\'s name', 'Viaduktstrasse, 571', 0, '8862', '', 1, 0),
(346, 'Providence3\'s name', 'Hohe Promenade, 977', 0, '4437', '', 17, 0),
(347, 'Providence4\'s name', 'Im Wyl, 732', 0, '5721', '', 9, 0),
(348, 'Providence5\'s name', 'Buchenrainstrasse, 747', 0, '9015', '', 19, 0),
(349, 'Providence6\'s name', 'Langstrasse, 365', 0, '5066', '', 12, 0),
(350, 'Clinique Suisse Montreux1\'s name', 'Felsberg, 623', 0, '1231', '', 10, 0),
(351, 'Clinique Suisse Montreux2\'s name', 'Kornamtsweg, 510', 0, '8240', '', 5, 0),
(352, 'Clinique Suisse Montreux3\'s name', 'Waidfussweg, 286', 0, '9268', '', 17, 0),
(353, 'Clinique Suisse Montreux4\'s name', 'Schiffbauplatz, 225', 0, '3880', '', 7, 0),
(354, 'Clinique Suisse Montreux5\'s name', 'Wunderlistrasse, 880', 0, '6953', '', 7, 0),
(355, 'Clinique Suisse Montreux6\'s name', 'Rötelsteig, 267', 0, '6354', '', 17, 0),
(356, 'CIC Riviera\'s name', 'Mimosenstrasse, 635', 0, '5576', '', 2, 0),
(357, 'CIC Chablais\'s name', 'Tulpenstrasse, 314', 0, '8679', '', 5, 0),
(358, 'ASMAV\'s name', 'Schanzeneggstrasse, 721', 0, '3125', '', 20, 0),
(359, 'Clinique Cecil\'s name', 'Am Hönggerberg, 403', 0, '9130', '', 9, 0),
(360, 'Fondation de nant\'s name', 'Breitenlooweg, 852', 0, '5128', '', 17, 0),
(361, 'Pharmacie 24\'s name', 'Gustav-Heinrich-Weg, 438', 0, '9351', '', 3, 0),
(362, 'Amavita Acacias\'s name', 'Sechseläutenplatz, 388', 0, '7408', '', 5, 0),
(363, 'Amavita Cardinaux\'s name', 'Spillmannweg, 249', 0, '9852', '', 18, 0),
(364, 'Amavita Jura\'s name', 'Wallisackerweg, 632', 0, '5974', '', 19, 0),
(365, 'Champs Frechets\'s name', 'Storchengasse, 374', 0, '1269', '', 12, 0),
(366, 'Pharmacie Cina\'s name', 'Schweizerhofgasse, 438', 0, '5564', '', 18, 0),
(367, 'Pharmacie D\'Herborence\'s name', 'Hausäcker, 542', 0, '8127', '', 19, 0),
(368, 'Pharmacie d\'Orsières\'s name', 'Bellevueplatz, 218', 0, '3968', '', 9, 0),
(369, 'Pharmacie de Clarens\'s name', 'Langackerstrasse, 231', 0, '5879', '', 3, 0),
(370, 'Pharmacie de Cortot\'s name', 'Freigutstrasse, 815', 0, '1352', '', 4, 0),
(371, 'Pharmacie de Florissant - Renens\'s name', 'Neugasse, 165', 0, '9416', '', 1, 0),
(372, 'Pharmacie de l\'ile à Rolle\'s name', 'Hauswiesenweg, 904', 0, '9486', '', 18, 0),
(373, 'Pharmacie du Tilleul\'s name', 'Bergellerstrasse, 71', 0, '4129', '', 3, 0),
(374, 'Pharmacie Saint-Léger\'s name', 'Lindenhofstrasse, 542', 0, '8078', '', 8, 0),
(375, 'Pharmacie Populaire - Officine : Varembe\'s name', 'Schlösslistrasse, 31', 0, '5109', '', 14, 0),
(376, 'Pharmacie Populaire - Officine : Trois-Chêne\'s name', 'Bärenbrüggli, 990', 0, '1106', '', 11, 0),
(377, 'Pharmacie Chablais-Gare\'s name', 'Andreaspark, 571', 0, '4674', '', 7, 0),
(378, 'Salveo\'s name', 'Wallisackerweg, 709', 0, '1404', '', 15, 0),
(379, 'Pharmapro\'s name', 'Karl-Bürkli-Strasse, 950', 0, '9640', '', 10, 0),
(380, 'Pharmacies de Garde à Martigny\'s name', 'Althoosstrasse, 759', 0, '2080', '', 9, 0),
(381, 'AXA\'s name', 'Kochstrasse, 550', 0, '2128', '', 2, 0),
(382, 'CSS\'s name', 'Höfliweg, 908', 0, '1675', '', 13, 0),
(383, 'Groupe Mutuel Philos\'s name', 'Ulrichstrasse, 901', 0, '4755', '', 17, 0),
(384, 'General Lee\'s name', 'Volkmarstrasse, 622', 0, '2306', '', 4, 0),
(385, 'Assura\'s name', 'Alemannensteig, 952', 0, '6594', '', 2, 0),
(386, 'SUVA\'s name', 'Römergasse, 148', 0, '4999', '', 18, 0),
(387, 'Helsana\'s name', 'Bühlwiesenstrasse, 380', 0, '4092', '', 9, 0),
(388, 'Concordia\'s name', 'Binzstrasse, 830', 0, '9315', '', 14, 0),
(389, 'Sanitas\'s name', 'Bogenweg, 678', 0, '6491', '', 8, 0),
(390, 'KPT/CPT Holding\'s name', 'Am Giessen, 364', 0, '4527', '', 8, 0),
(391, 'Wincare\'s name', 'Renggersteig, 546', 0, '6019', '', 14, 0),
(392, 'Atupri\'s name', 'Laufferweg, 18', 0, '6062', '', 12, 0),
(393, 'ÖKK\'s name', 'Wasserschöpfi, 576', 0, '8530', '', 17, 0),
(394, 'EGK-Gesundheitskasse\'s name', 'An der Specki, 62', 0, '7374', '', 11, 0),
(395, 'Sympany\'s name', 'Sunnige Hof, 214', 0, '5626', '', 7, 0),
(396, 'Sansan Versicherungen\'s name', 'Rudolf-Brun-Brücke, 119', 0, '1988', '', 7, 0),
(397, 'Agrisano\'s name', 'Baumgartnerstrasse, 482', 0, '9398', '', 13, 0),
(398, 'Avanex\'s name', 'Kornhausbrücke, 924', 0, '5628', '', 18, 0),
(399, 'Carena Schweiz\'s name', 'Fronwaldweg, 787', 0, '9561', '', 15, 0),
(400, 'Fondation AMB\'s name', 'Talweg, 690', 0, '6007', '', 3, 0),
(401, 'AXA\'s name', 'Lengghalde, 803', 0, '1813', '', 20, 0),
(402, 'CSS\'s name', 'Rötelsteig, 819', 0, '5592', '', 4, 0),
(403, 'Groupe Mutuel Philos\'s name', 'Neumünsterallee, 948', 0, '8203', '', 11, 0),
(404, 'General Lee\'s name', 'Rislingstrasse, 883', 0, '5736', '', 9, 0),
(405, 'Assura\'s name', 'Hanfrose, 878', 0, '3051', '', 10, 0),
(406, 'SUVA\'s name', 'Peterstobelweg, 423', 0, '6683', '', 11, 0),
(407, 'Helsana\'s name', 'Weinbergfussweg, 607', 0, '5588', '', 3, 0),
(408, 'Concordia\'s name', 'Sackzelg, 638', 0, '9862', '', 9, 0),
(409, 'Sanitas\'s name', 'Bolleystrasse, 714', 0, '1816', '', 3, 0),
(410, 'KPT/CPT Holding\'s name', 'Loorentorweg, 517', 0, '4642', '', 14, 0),
(411, 'Wincare\'s name', 'Holunderhof, 950', 0, '7889', '', 2, 0),
(412, 'Atupri\'s name', 'Waidbadstrasse, 943', 0, '1945', '', 6, 0),
(413, 'ÖKK\'s name', 'Ulmenweg, 910', 0, '4280', '', 19, 0),
(414, 'EGK-Gesundheitskasse\'s name', 'Schindlerstrasse, 596', 0, '5252', '', 8, 0),
(415, 'Sympany\'s name', 'Rumpelhaldenweg, 343', 0, '7851', '', 9, 0),
(416, 'Sansan Versicherungen\'s name', 'Uetlibergweg, 582', 0, '4912', '', 5, 0),
(417, 'Agrisano\'s name', 'Landoltstrasse, 787', 0, '8974', '', 4, 0),
(418, 'Avanex\'s name', 'Amazonenweg, 187', 0, '6848', '', 1, 0),
(419, 'Carena Schweiz\'s name', 'Fortunagasse, 163', 0, '9874', '', 9, 0),
(420, 'Fondation AMB\'s name', 'Rämistrasse, 726', 0, '7857', '', 15, 0),
(421, 'Fondation Rive-Neuve\'s name', 'Batteriesteig, 5', 0, '8528', '', 16, 0),
(422, 'OMSV\'s name', 'Hürstringstrasse, 832', 0, '4516', '', 17, 0),
(423, 'ASI Section Vaud\'s name', 'Zwirnerhalde, 73', 0, '1931', '', 16, 0),
(424, 'ARLD\'s name', 'Pfirsichstrasse, 792', 0, '7565', '', 19, 0),
(425, 'PhisioSwiss\'s name', 'Kranzweg, 754', 0, '6636', '', 3, 0),
(426, 'SVMED\'s name', 'Billrothweg, 541', 0, '5772', '', 4, 0),
(427, 'SVMD\'s name', 'Spyriplatz, 295', 0, '9912', '', 15, 0),
(428, 'Dr Gapany\'s name', 'Am Luchsgraben, 246', 0, '5415', '', 14, 0),
(429, 'Dr René Lysek\'s name', 'Glimmerweg, 220', 0, '3470', '', 10, 0),
(430, 'AVADOL\'s name', 'Bleulerstrasse, 362', 0, '1846', '', 5, 0),
(431, 'AVSD\'s name', 'Auf der Mauer, 980', 0, '7463', '', 3, 0),
(432, 'AVADOL\'s name', 'Tessinerplatz, 792', 0, '6668', '', 17, 0),
(433, 'PRENDPLACE\'s name', 'Mainaustrasse, 70', 0, '2117', '', 1, 0),
(434, 'PSY VS\'s name', 'Schmidgasse, 755', 0, '1766', '', 11, 0),
(435, 'IRO\'s name', 'Aprikosenstrasse, 215', 0, '5268', '', 1, 0),
(436, 'ASSAL\'s name', 'Felsenkellerweg, 316', 0, '1396', '', 13, 0),
(437, 'CM Lignon\'s name', 'Im Klösterli, 659', 0, '5262', '', 9, 0),
(438, 'CMS Magellan\'s name', 'Reservoirweg, 349', 0, '2374', '', 14, 0),
(439, 'EMS Val Fleuri\'s name', 'Neugutstrasse, 768', 0, '1806', '', 8, 0),
(440, 'Fondation Fénix\'s name', 'Jonas-Furrer-Strasse, 422', 0, '7583', '', 16, 0),
(441, 'Array\'s name', 'Häringsplatz, 386', 0, '7900', '', 11, 0),
(442, 'Array\'s name', 'Michelstrasse, 130', 0, '4032', '', 10, 0),
(443, 'Array\'s name', 'Marie-Baum-Platz, 610', 0, '7140', '', 12, 0),
(444, 'Array\'s name', 'Schützengasse, 258', 0, '2200', '', 15, 0),
(445, 'Array\'s name', 'Dennlerstrasse, 575', 0, '2337', '', 1, 0),
(446, 'Array\'s name', 'Hönggerstrasse, 614', 0, '8823', '', 6, 0),
(447, 'Array\'s name', 'Kruggasse, 249', 0, '6543', '', 4, 0),
(448, 'Array\'s name', 'Hirschengasse, 772', 0, '8926', '', 7, 0),
(449, 'Array\'s name', 'Dennlerstrasse, 284', 0, '3997', '', 5, 0),
(450, 'Array\'s name', 'Sillerweg, 967', 0, '6149', '', 10, 0),
(451, 'Array\'s name', 'Grütstrasse, 692', 0, '9179', '', 17, 0),
(452, 'Array\'s name', 'Feldblumenweg, 16', 0, '5622', '', 9, 0),
(453, 'Array\'s name', 'Steinentischstrasse, 687', 0, '3879', '', 19, 0),
(454, 'Array\'s name', 'Traugottstrasse, 508', 0, '2239', '', 1, 0),
(455, 'Array\'s name', 'Kanonengasse, 144', 0, '7032', '', 2, 0),
(456, 'Array\'s name', 'Lenggfussweg, 342', 0, '2376', '', 16, 0),
(457, 'Array\'s name', 'Bruderholzweg, 698', 0, '5722', '', 17, 0),
(458, 'Array\'s name', 'Unterholzweg, 158', 0, '6881', '', 17, 0),
(459, 'Array\'s name', 'Räuberweg, 497', 0, '2545', '', 6, 0),
(460, 'Array\'s name', 'Traubenstrasse, 581', 0, '2663', '', 3, 0),
(461, 'Array\'s name', 'Gmeimeriweg, 131', 0, '2584', '', 4, 0),
(462, 'Array\'s name', 'Kornhausbrücke, 137', 0, '4122', '', 19, 0),
(473, NULL, 'Boylston Street', 1140, '02215', 'MA', NULL, 1),
(474, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(475, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(477, NULL, 'Boylston Street', 1140, '02215', 'MA', 21, 1),
(478, NULL, 'Greenwich Street', 424, '10013', 'NY', 29, 1),
(479, NULL, 'Punchbowl Street', 1151, '96813', 'HI', 30, 1),
(480, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(481, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(482, NULL, 'Boylston Street', 1140, '02215', 'MA', 21, 1),
(483, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(484, NULL, 'Boylston Street', 1140, '02215', 'MA', 21, 1),
(485, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(486, NULL, 'Boylston Street', 1140, '02215', 'MA', 21, 1),
(487, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(488, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(489, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(490, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(491, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(492, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(493, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(494, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(495, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(496, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(497, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(498, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(499, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(500, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(501, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(502, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(503, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(504, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(505, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(506, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(507, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(508, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(509, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(510, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(511, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(512, NULL, 'Boylston Street', 1140, '02215', 'MA', 21, 1),
(513, NULL, 'Amsterdam Avenue', 1160, '10027', 'NY', 29, 1),
(514, NULL, '6th Avenue', 1366, '10019', 'NY', 29, 1),
(515, NULL, 'Greenwich Street', 112, '10013', 'NY', 29, 1),
(516, NULL, 'Market Street', 232, '19106', 'PA', 31, 1),
(517, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(518, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(519, NULL, NULL, NULL, NULL, 'TX', NULL, 1),
(520, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(521, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(522, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(523, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(524, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(525, NULL, NULL, NULL, NULL, 'Telangana', NULL, 7),
(526, NULL, 'Badenerstrasse', 110, '8004', 'ZH', 1, 8),
(527, NULL, 'Route de l\'Aéroport', 11, '1215', 'GE', 32, 8),
(528, NULL, 'Route de l\'Aéroport', 11, '1215', 'GE', 32, 8),
(529, NULL, 'Route de l\'Aéroport', 11, '1215', 'GE', 32, 8),
(530, NULL, 'Seestrasse', 110, '8002', 'ZH', 1, 8);

-- --------------------------------------------------------

--
-- Table structure for table `t_addressbelongtocontact`
--

CREATE TABLE `t_addressbelongtocontact` (
  `fkAddress` int(11) NOT NULL,
  `fkContact` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_addressbelongtocontact`
--

INSERT INTO `t_addressbelongtocontact` (`fkAddress`, `fkContact`) VALUES
(477, 6),
(478, 9),
(479, 10),
(514, 11),
(515, 12),
(516, 13);

-- --------------------------------------------------------

--
-- Table structure for table `t_addressbelongtoemployees`
--

CREATE TABLE `t_addressbelongtoemployees` (
  `idxAddress` int(11) NOT NULL,
  `idxEmployees` int(11) NOT NULL,
  `idxAddressType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_addressbelongtoemployees`
--

INSERT INTO `t_addressbelongtoemployees` (`idxAddress`, `idxEmployees`, `idxAddressType`) VALUES
(212, 1, 1),
(213, 2, 1),
(214, 3, 2),
(215, 4, 2),
(216, 5, 2),
(217, 6, 1),
(218, 7, 1),
(219, 8, 1),
(220, 9, 2),
(221, 10, 1),
(222, 11, 2),
(223, 12, 2),
(224, 13, 1),
(225, 14, 2),
(226, 15, 1),
(227, 16, 1),
(228, 17, 2),
(229, 18, 2),
(230, 19, 2),
(231, 20, 2),
(232, 21, 1),
(233, 22, 2),
(234, 23, 2),
(235, 24, 1),
(236, 25, 2),
(237, 26, 2),
(238, 27, 1),
(239, 28, 2),
(240, 29, 1),
(241, 30, 2),
(242, 31, 2),
(243, 32, 2),
(244, 33, 2),
(245, 34, 1),
(246, 35, 1),
(247, 36, 2),
(248, 37, 1),
(249, 38, 2),
(250, 39, 1),
(251, 40, 1),
(252, 41, 2),
(253, 42, 2),
(254, 43, 2),
(255, 44, 2),
(256, 45, 1),
(257, 46, 2),
(258, 47, 1),
(259, 48, 2),
(260, 49, 2),
(261, 50, 1),
(262, 51, 1),
(263, 52, 2),
(264, 53, 2),
(265, 54, 2),
(266, 55, 2),
(267, 56, 2),
(268, 57, 1),
(269, 58, 2),
(270, 59, 2),
(271, 60, 2),
(272, 61, 2),
(273, 62, 2),
(274, 63, 1),
(275, 64, 1),
(276, 65, 1),
(277, 66, 2),
(278, 67, 1),
(279, 68, 1),
(280, 69, 1),
(281, 70, 1),
(282, 71, 1),
(283, 72, 2),
(284, 73, 1),
(285, 74, 2),
(286, 75, 2),
(287, 76, 1),
(288, 77, 2),
(289, 78, 1),
(290, 79, 2),
(291, 80, 2),
(292, 81, 1),
(293, 82, 1),
(294, 83, 1),
(295, 84, 2),
(296, 85, 2),
(297, 86, 1),
(298, 87, 2),
(299, 88, 1),
(300, 89, 1),
(301, 90, 2),
(302, 91, 1),
(303, 92, 2),
(304, 93, 2),
(305, 94, 1),
(306, 95, 2),
(307, 96, 2),
(308, 97, 2),
(309, 98, 1),
(310, 99, 2),
(311, 100, 1),
(312, 101, 2),
(313, 102, 1),
(314, 103, 1),
(315, 104, 2),
(316, 105, 2),
(317, 106, 1),
(318, 107, 1),
(319, 108, 2),
(320, 109, 1),
(321, 110, 1),
(322, 111, 1),
(323, 112, 1),
(324, 113, 1),
(325, 114, 1),
(326, 115, 1),
(327, 116, 2),
(328, 117, 2),
(329, 118, 2),
(330, 119, 1),
(331, 120, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_addressbelongtoinsurances`
--

CREATE TABLE `t_addressbelongtoinsurances` (
  `idxAddress` int(11) NOT NULL,
  `idxInsurances` int(11) NOT NULL,
  `idxAddressType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_addressbelongtoinsurances`
--

INSERT INTO `t_addressbelongtoinsurances` (`idxAddress`, `idxInsurances`, `idxAddressType`) VALUES
(443, 1, 1),
(444, 2, 1),
(445, 3, 2),
(446, 4, 1),
(447, 5, 1),
(448, 6, 2),
(449, 7, 1),
(450, 8, 2),
(451, 9, 1),
(452, 10, 2),
(453, 11, 2),
(454, 12, 2),
(455, 13, 1),
(456, 14, 1),
(457, 15, 2),
(458, 16, 2),
(459, 17, 1),
(460, 18, 1),
(461, 19, 2),
(462, 20, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_addressbelongtomedicalestablishment`
--

CREATE TABLE `t_addressbelongtomedicalestablishment` (
  `idxAddress` int(11) NOT NULL,
  `idxMedicalestablishment` int(11) NOT NULL,
  `idxAddressType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_addressbelongtomedicalestablishment`
--

INSERT INTO `t_addressbelongtomedicalestablishment` (`idxAddress`, `idxMedicalestablishment`, `idxAddressType`) VALUES
(332, 1, 2),
(333, 2, 1),
(334, 3, 2),
(335, 4, 1),
(336, 5, 1),
(337, 6, 1),
(338, 7, 2),
(339, 8, 2),
(340, 9, 2),
(341, 10, 1),
(342, 11, 1),
(343, 12, 2),
(344, 13, 2),
(345, 14, 2),
(346, 15, 2),
(347, 16, 1),
(348, 17, 2),
(349, 18, 2),
(350, 19, 1),
(351, 20, 1),
(352, 21, 1),
(353, 22, 2),
(354, 23, 2),
(355, 24, 2),
(356, 25, 1),
(357, 26, 1),
(358, 27, 2),
(359, 28, 2),
(360, 29, 2),
(361, 30, 1),
(362, 31, 1),
(363, 32, 2),
(364, 33, 2),
(365, 34, 1),
(366, 35, 1),
(367, 36, 1),
(368, 37, 2),
(369, 38, 1),
(370, 39, 1),
(371, 40, 2),
(372, 41, 1),
(373, 42, 2),
(374, 43, 1),
(375, 44, 1),
(376, 45, 2),
(377, 46, 1),
(378, 47, 1),
(379, 48, 2),
(380, 49, 1),
(381, 50, 1),
(382, 51, 2),
(383, 52, 2),
(384, 53, 1),
(385, 54, 1),
(386, 55, 1),
(387, 56, 2),
(388, 57, 1),
(389, 58, 1),
(390, 59, 1),
(391, 60, 2),
(392, 61, 2),
(393, 62, 2),
(394, 63, 2),
(395, 64, 1),
(396, 65, 1),
(397, 66, 2),
(398, 67, 1),
(399, 68, 2),
(400, 69, 1),
(401, 70, 2),
(402, 71, 2),
(403, 72, 2),
(404, 73, 2),
(405, 74, 2),
(406, 75, 1),
(407, 76, 2),
(408, 77, 2),
(409, 78, 2),
(410, 79, 1),
(411, 80, 2),
(412, 81, 2),
(413, 82, 2),
(414, 83, 1),
(415, 84, 2),
(416, 85, 1),
(417, 86, 1),
(418, 87, 2),
(419, 88, 2),
(420, 89, 2),
(421, 90, 2),
(422, 91, 1),
(423, 92, 2),
(424, 93, 1),
(425, 94, 2),
(426, 95, 1),
(427, 96, 2),
(428, 97, 2),
(429, 98, 2),
(430, 99, 2),
(431, 100, 2),
(432, 101, 1),
(433, 102, 2),
(434, 103, 1),
(435, 104, 2),
(436, 105, 1),
(437, 106, 2),
(438, 107, 2),
(439, 108, 1),
(440, 109, 2),
(447, 208, 473),
(448, 215, 474),
(449, 216, 475),
(450, 219, 480),
(451, 220, 481);

-- --------------------------------------------------------

--
-- Table structure for table `t_addressbelongtopatient`
--

CREATE TABLE `t_addressbelongtopatient` (
  `idxAddress` int(11) NOT NULL,
  `idxPatient` int(11) NOT NULL,
  `idxAddressType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_addressbelongtopatient`
--

INSERT INTO `t_addressbelongtopatient` (`idxAddress`, `idxPatient`, `idxAddressType`) VALUES
(1, 1, 1),
(2, 2, 1),
(3, 3, 1),
(4, 4, 2),
(5, 5, 1),
(6, 6, 2),
(7, 7, 2),
(8, 8, 1),
(9, 9, 2),
(10, 10, 1),
(11, 11, 1),
(12, 12, 2),
(13, 13, 2),
(14, 14, 1),
(15, 15, 1),
(16, 16, 1),
(17, 17, 1),
(18, 18, 1),
(19, 19, 1),
(20, 20, 1),
(21, 21, 1),
(22, 22, 2),
(23, 23, 2),
(24, 24, 1),
(25, 25, 1),
(26, 26, 2),
(27, 27, 2),
(28, 28, 2),
(29, 29, 2),
(30, 30, 1),
(31, 31, 2),
(32, 32, 2),
(33, 33, 2),
(34, 34, 2),
(35, 35, 1),
(36, 36, 2),
(37, 37, 1),
(38, 38, 2),
(39, 39, 2),
(40, 40, 1),
(41, 41, 1),
(42, 42, 2),
(43, 43, 1),
(44, 44, 2),
(45, 45, 2),
(46, 46, 2),
(47, 47, 2),
(48, 48, 1),
(49, 49, 2),
(50, 50, 2),
(51, 51, 2),
(52, 52, 2),
(53, 53, 1),
(54, 54, 2),
(55, 55, 2),
(56, 56, 2),
(57, 57, 1),
(58, 58, 2),
(59, 59, 2),
(60, 60, 1),
(61, 61, 2),
(62, 62, 1),
(63, 63, 2),
(64, 64, 2),
(65, 65, 2),
(66, 66, 2),
(67, 67, 2),
(68, 68, 2),
(69, 69, 2),
(70, 70, 2),
(71, 71, 2),
(72, 72, 2),
(73, 73, 2),
(74, 74, 2),
(75, 75, 2),
(76, 76, 2),
(77, 77, 1),
(78, 78, 2),
(79, 79, 2),
(80, 80, 1),
(81, 81, 1),
(82, 82, 2),
(83, 83, 1),
(84, 84, 1),
(85, 85, 1),
(86, 86, 1),
(87, 87, 1),
(88, 88, 2),
(89, 89, 1),
(90, 90, 2),
(91, 91, 2),
(92, 92, 2),
(93, 93, 1),
(94, 94, 1),
(95, 95, 2),
(96, 96, 2),
(97, 97, 1),
(98, 98, 1),
(99, 99, 2),
(100, 100, 2),
(101, 101, 1),
(102, 102, 1),
(103, 103, 1),
(104, 104, 2),
(105, 105, 1),
(106, 106, 1),
(107, 107, 1),
(108, 108, 1),
(109, 109, 2),
(110, 110, 1),
(111, 111, 1),
(112, 112, 1),
(113, 113, 1),
(114, 114, 1),
(115, 115, 2),
(116, 116, 1),
(117, 117, 1),
(118, 118, 2),
(119, 119, 2),
(120, 120, 1),
(482, 128, 1),
(483, 128, 2),
(484, 129, 1),
(485, 129, 2),
(486, 130, 1),
(487, 130, 2),
(488, 131, 1),
(489, 132, 1),
(490, 133, 1),
(491, 134, 1),
(492, 135, 1),
(493, 136, 1),
(494, 137, 1),
(495, 138, 1),
(496, 139, 1),
(497, 140, 1),
(498, 141, 1),
(499, 142, 1),
(500, 143, 1),
(501, 144, 1),
(502, 145, 1),
(503, 146, 1),
(504, 147, 1),
(505, 148, 1),
(506, 149, 1),
(507, 150, 1),
(508, 151, 1),
(509, 152, 1),
(510, 153, 1),
(511, 154, 1),
(512, 155, 1),
(513, 156, 1),
(517, 158, 1),
(518, 159, 1),
(519, 159, 2),
(520, 160, 1),
(521, 161, 1),
(522, 162, 1),
(523, 163, 1),
(524, 164, 1),
(525, 165, 1),
(526, 166, 1),
(527, 167, 1),
(528, 168, 1),
(529, 169, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_addresstype`
--

CREATE TABLE `t_addresstype` (
  `idAddressType` int(11) NOT NULL,
  `addtypName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_addresstype`
--

INSERT INTO `t_addresstype` (`idAddressType`, `addtypName`) VALUES
(1, 'Communication'),
(2, 'Billing');

-- --------------------------------------------------------

--
-- Table structure for table `t_allergy`
--

CREATE TABLE `t_allergy` (
  `idAllergy` smallint(6) NOT NULL,
  `allName` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_allergy`
--

INSERT INTO `t_allergy` (`idAllergy`, `allName`) VALUES
(1, 'Dust'),
(2, 'Smoke'),
(3, 'du');

-- --------------------------------------------------------

--
-- Table structure for table `t_anamnesysandsymptoms`
--

CREATE TABLE `t_anamnesysandsymptoms` (
  `idAnamnesysandsymptoms` int(6) NOT NULL,
  `anaDescription` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_anamnesysandsymptoms`
--

INSERT INTO `t_anamnesysandsymptoms` (`idAnamnesysandsymptoms`, `anaDescription`) VALUES
(1, 'finger ache'),
(2, 'ргргр'),
(3, 'щшощшо');

-- --------------------------------------------------------

--
-- Table structure for table `t_anamnesysandsymptomsbelongtoconsultations`
--

CREATE TABLE `t_anamnesysandsymptomsbelongtoconsultations` (
  `fkAnamnesysandsymptoms` int(6) NOT NULL,
  `fkConsultations` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_anamnesysandsymptomsbelongtoconsultations`
--

INSERT INTO `t_anamnesysandsymptomsbelongtoconsultations` (`fkAnamnesysandsymptoms`, `fkConsultations`) VALUES
(1, 28),
(2, 29),
(3, 30);

-- --------------------------------------------------------

--
-- Table structure for table `t_appointment`
--

CREATE TABLE `t_appointment` (
  `idAppointment` int(11) NOT NULL,
  `appName` varchar(255) DEFAULT NULL,
  `appDescription` varchar(255) DEFAULT NULL,
  `appDate` date DEFAULT NULL,
  `appHour` time DEFAULT NULL,
  `appDuration` varchar(255) DEFAULT NULL COMMENT 'this is in second',
  `appType` int(2) DEFAULT NULL,
  `appIsEmergency` tinyint(1) DEFAULT NULL,
  `fkCalendar` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_appointment`
--

INSERT INTO `t_appointment` (`idAppointment`, `appName`, `appDescription`, `appDate`, `appHour`, `appDuration`, `appType`, `appIsEmergency`, `fkCalendar`) VALUES
(14, 'take docs', 'take docs from my secretary', '2018-10-18', '13:30:00', '00:10', 1, 0, 1),
(15, 'eat meal with Alex', 'Go to the kintchen and eat the meal', '2018-10-19', '11:08:10', '00:30', 2, 0, 1),
(21, 'take kids from school', 'don\'t forget to talk to their teacher', '2018-10-18', '23:30:00', '01:00', 3, 0, 1),
(28, 'get fuels', 'in gas station number 5', '2018-10-17', '10:30:00', '00:45', 4, 0, 1),
(31, 'make coffee', 'remind Aaron, Jason and Nicolas to do the coffee to Joshua if coffee exists', '2018-10-01', '12:30:00', '00:30', 1, 0, 1),
(32, 'get DNA structure', 'need a consultation of Maximilian', '2018-10-16', '14:45:00', '03:20', 2, 0, 1),
(33, 'test', 'test', '2018-10-18', '10:30:00', '00:45', 2, 0, 1),
(34, 'test', 'test', '2018-10-18', '10:40:00', '00:20', 3, 0, 1),
(35, 'test', 'test', '2018-11-02', '10:40:00', '00:20', 4, 0, 1),
(36, 'test', 'test', '2018-10-18', '10:40:00', '00:25', 1, 0, 1),
(37, 'teste', '3e3e3e3', '2018-10-18', '10:45:00', '00:34', 2, 0, 1),
(38, 'teste', '3e3e3e3', '2018-10-18', '10:45:00', '00:34', 3, 0, 1),
(39, 'Test', 'bauibauid', '2018-10-18', '09:20:00', '00:20', 4, 0, 1),
(40, 'Test 2', 'bauibauid', '2018-10-18', '09:20:00', '00:20', 1, 0, 1),
(41, 'Test 2', 'bauibauid', '2018-10-18', '09:20:00', '00:20', 2, 0, 1),
(42, 'Test 2', 'bauibauid', '2018-10-18', '09:20:00', '00:20', 2, 0, 1),
(43, 'Test 3', 'bauibauid', '2018-10-18', '09:20:00', '00:40', 3, 0, 1),
(44, 'Test 4', 'bauibauid', '2018-10-18', '09:25:00', '00:40', 4, 0, 1),
(45, 'Test 5', 'bauibauid', '2018-10-18', '09:25:00', '00:10', 1, 0, 1),
(46, 'Test 5', 'bauibauid', '2018-10-18', '09:40:00', '00:20', 2, 0, 1),
(47, 'Test 6', 'bauibauid', '2018-10-18', '10:00:00', '00:10', 3, 0, 1),
(48, 'test 7', 'test 7 description', '2018-10-22', '16:00:00', '00:11', 2, 0, 1),
(49, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(50, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(51, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(52, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(53, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(54, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(55, 'test 8', 'get analysis', '2018-10-22', '15:00:00', '01:30', 1, 0, 1),
(56, 'coffe', 'get coffee machine', '2018-10-22', '16:00:00', '01:00', 3, 0, 1),
(57, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(58, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(59, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(60, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(61, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(62, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(63, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(64, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(65, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 3, 0, 1),
(66, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(67, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(68, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(69, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(70, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(71, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(72, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(73, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(74, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(75, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 4, 0, 1),
(76, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 2, 0, 1),
(77, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 2, 0, 1),
(78, 'coffe', 'get coffee machine', '2018-10-22', '15:00:00', '01:00', 2, 0, 1),
(79, 'Test', 'First Test of agenda', '2018-10-23', '07:30:00', '00:20', 1, 0, 1),
(80, 'Consultation', 'Consultation simple', '2018-10-23', '07:50:00', '00:20', 1, 0, 1),
(81, 'Consultation', 'Consultation simple', '2018-10-23', '08:10:00', '00:20', 1, 0, 1),
(82, 'Consultation', 'Consultation simple', '2018-10-23', '08:30:00', '00:20', 1, 0, 1),
(83, 'bug + 20', 'Consultation simple', '2018-10-23', '08:50:00', '00:20', 1, 0, 1),
(84, 'Consultation', 'Consultation simple', '2018-10-23', '09:10:00', '00:20', 1, 0, 1),
(85, 'Consultation', 'Consultation simple', '2018-10-23', '09:30:00', '00:20', 1, 0, 1),
(86, 'Consultation', 'Consultation simple', '2018-10-23', '09:50:00', '00:20', 1, 0, 1),
(87, 'Consultation', 'Consultation simple', '2018-10-23', '08:00:00', '00:20', 3, 0, 1),
(88, 'Consultation', 'Consultation simple', '2018-10-23', '08:20:00', '00:20', 3, 0, 1),
(89, 'Consultation', 'Consultation simple', '2018-10-23', '08:40:00', '00:20', 3, 0, 1),
(90, 'Consultation', 'Consultation simple', '2018-10-23', '09:00:00', '00:20', 3, 0, 1),
(91, 'Consultation', 'Consultation simple', '2018-10-23', '09:20:00', '00:20', 3, 0, 1),
(92, 'Consultation', 'Consultation simple', '2018-10-23', '09:40:00', '00:20', 3, 0, 1),
(93, 'Consultation', 'Consultation simple', '2018-10-23', '10:00:00', '00:20', 3, 0, 1),
(94, 'Visite Plombier', 'Les toilettes ont lacher', '2018-10-23', '09:00:00', '00:50', 4, 0, 1),
(95, 'Visite Plombier', 'Les toilettes ont lacher', '2018-10-23', '09:00:00', '00:50', 4, 0, 1),
(96, 'Bug1', 'dsfs', '2018-10-23', '10:20:00', '00:20', 1, 0, 1),
(97, 'Bug1', 'dsfs', '2018-10-23', '10:20:00', '00:20', 4, 0, 1),
(98, 'Sunday morning', 'lazy', '2018-10-21', '10:29:00', '02:30', 4, 0, 1),
(99, 'take docs', 'don\'t forget to talk to their teacher', '2018-10-28', '12:00:00', '02:00', 3, 0, 1),
(100, 'make coffee', 'remind Aaron, Jason and Nicolas to do the coffee to Joshua if coffee exists', '2018-10-23', '07:10:00', '01:00', 4, 0, 1),
(101, 'make coffee', 'remind Aaron, Jason and Nicolas to do the coffee to Joshua if coffee exists', '2018-10-23', '07:10:00', '01:00', 4, 0, 1),
(102, 'make coffee', 'remind Aaron, Jason and Nicolas to do the coffee to Joshua if coffee exists', '2018-10-23', '07:10:00', '01:00', 4, 0, 1),
(103, 'event updated', 'remind Aaron, Jason and Nicolas to do the coffee to Joshua if coffee exists', '2018-10-23', '07:10:00', '01:00', 4, 0, 1),
(104, 'event updated2', 'remind Aaron, Jason and Nicolas to do the coffee to Joshua if coffee exists', '2018-10-23', '07:10:00', '01:00', 4, 0, 1),
(105, 'test alexander', 'for the test of agenda', '2018-10-18', '08:10:00', '00:10', 1, 0, 1),
(106, 'regular consultation', '', '2018-11-01', '19:10:00', '0:20', 1, 0, 1),
(107, 'regular consultation', '', '2018-11-01', '19:10:00', '0:20', 1, 0, 1),
(108, 'regular consultation', '', '2018-10-31', '08:30:00', '0:20', 1, 0, 1),
(109, 'regular consultation', '', '2018-10-31', '08:30:00', '0:20', 1, 0, 1),
(110, 'regular consultation', '', '2018-10-31', '09:10:00', '0:20', 1, 0, 1),
(111, 'regular consultation', '', '2018-10-31', '12:30:00', '1:0', 1, 0, 1),
(112, 'regular consultation', '', '2018-10-31', '08:20:00', '0:25', 1, 0, 1),
(113, 'regular consultation', '', '2018-10-31', '07:30:00', '0:25', 1, 0, 1),
(114, 'regular consultation', '', '2018-11-02', '08:20:00', '0:25', 1, 0, 1),
(115, 'regular consultation', '', '2018-11-02', '08:20:00', '0:25', 1, 0, 1),
(116, 'regular consultation', '', '2018-11-02', '08:20:00', '0:25', 1, 0, 1),
(117, 'regular consultation', '', '2018-11-02', '08:45:00', '0:25', 1, 0, 1),
(118, 'regular consultation', '', '2018-11-02', '08:45:00', '0:25', 1, 0, 1),
(119, 'regular consultation', '', '2018-11-02', '08:45:00', '0:25', 1, 0, 1),
(120, 'regular consultation', '', '2018-11-02', '09:10:00', '0:25', 1, 0, 1),
(121, 'regular consultation', '', '2018-11-02', '09:10:00', '0:25', 1, 0, 1),
(122, 'regular consultation', '', '2018-11-02', '09:10:00', '0:25', 1, 0, 1),
(123, 'regular consultation', '', '2018-11-02', '09:35:00', '0:25', 1, 0, 1),
(124, 'regular consultation', '', '2018-11-02', '09:35:00', '0:25', 1, 0, 1),
(125, 'regular consultation', '', '2018-11-02', '09:35:00', '0:25', 1, 0, 1),
(126, 'regular consultation', '', '2018-11-02', '10:00:00', '0:25', 1, 0, 1),
(127, 'regular consultation', '', '2018-11-02', '10:00:00', '0:25', 1, 0, 1),
(128, 'regular consultation', '', '2018-11-02', '10:00:00', '0:25', 1, 0, 1),
(129, 'regular consultation', '', '2018-11-02', '10:25:00', '0:25', 1, 0, 1),
(130, 'regular consultation', '', '2018-11-02', '10:25:00', '0:25', 1, 0, 1),
(131, 'regular consultation', '', '2018-11-02', '10:25:00', '0:25', 1, 0, 1),
(132, 'regular consultation', '', '2018-11-02', '10:50:00', '0:25', 1, 0, 1),
(133, 'regular consultation', '', '2018-11-02', '10:50:00', '0:25', 1, 0, 1),
(134, 'regular consultation', '', '2018-11-02', '10:50:00', '0:25', 1, 0, 1),
(135, 'regular consultation', '', '2018-11-02', '11:15:00', '0:25', 1, 0, 1),
(136, 'regular consultation', '', '2018-11-02', '11:15:00', '0:25', 1, 0, 1),
(137, 'regular consultation', '', '2018-11-02', '11:15:00', '0:25', 1, 0, 1),
(138, 'regular consultation', '', '2018-11-02', '11:40:00', '0:25', 1, 0, 1),
(139, 'regular consultation', '', '2018-11-02', '11:40:00', '0:25', 1, 0, 1),
(140, 'regular consultation', '', '2018-10-31', '07:30:00', '0:40', 1, 0, 1),
(141, 'regular consultation', '', '2018-10-31', '07:30:00', '0:20', 1, 0, 1),
(142, 'regular consultation', '', '2018-10-31', '10:30:00', '0:20', 1, 0, 1),
(143, 'regular consultation', '', '2018-10-31', '10:50:00', '0:20', 1, 0, 1),
(144, 'regular consultation', '', '2018-10-31', '11:10:00', '0:20', 1, 0, 1),
(145, 'regular consultation', '', '2018-10-31', '11:30:00', '0:20', 1, 0, 1),
(146, 'regular consultation', '', '2018-10-31', '10:10:00', '0:20', 1, 0, 1),
(147, 'regular consultation', '', '2018-10-31', '11:30:00', '1:0', 1, 0, 1),
(148, 'regular consultation', '', '2018-10-31', '12:30:00', '1:0', 1, 0, 1),
(149, 'regular consultation', '', '2018-10-31', '13:30:00', '1:0', 1, 0, 1),
(150, 'regular consultation', '', '2018-10-31', '14:30:00', '1:0', 1, 0, 1),
(151, 'regular consultation', '', '2018-10-31', '15:30:00', '1:0', 1, 0, 1),
(152, 'regular consultation', '', '2018-10-31', '16:30:00', '1:0', 1, 0, 1),
(153, 'regular consultation', '', '2018-10-31', '17:30:00', '1:0', 1, 0, 1),
(154, 'regular consultation', '', '2018-10-31', '18:30:00', '1:0', 1, 0, 1),
(155, 'regular consultation', '', '2018-10-31', '07:30:00', '1:0', 1, 0, 1),
(156, 'regular consultation', '', '2018-10-31', '08:30:00', '1:0', 1, 0, 1),
(157, 'regular consultation', '', '2018-10-31', '09:30:00', '1:0', 1, 0, 1),
(158, 'regular consultation', '', '2018-10-31', '10:30:00', '1:0', 1, 0, 1),
(159, 'regular consultation', '', '2018-10-31', '07:30:00', '0:50', 1, 0, 1),
(160, 'regular consultation', '', '2018-10-31', '08:20:00', '0:50', 1, 0, 1),
(161, 'regular consultation', '', '2018-10-31', '09:10:00', '0:50', 1, 0, 1),
(162, 'regular consultation', '', '2018-10-31', '10:00:00', '0:50', 1, 0, 1),
(163, 'regular consultation', '', '2018-10-31', '10:50:00', '0:50', 1, 0, 1),
(164, 'regular consultation', '', '2018-10-31', '11:40:00', '0:50', 1, 0, 1),
(165, 'regular consultation', '', '2018-10-31', '12:30:00', '0:50', 1, 0, 1),
(166, 'regular consultation', '', '2018-10-31', '13:20:00', '0:50', 1, 0, 1),
(167, 'regular consultation', '', '2018-10-31', '14:10:00', '0:50', 1, 0, 1),
(168, 'regular consultation', '', '2018-10-31', '15:00:00', '0:50', 1, 0, 1),
(169, 'regular consultation', '', '2018-10-31', '07:30:00', '0:50', 1, 0, 1),
(170, 'regular consultation', '', '2018-10-31', '08:20:00', '0:50', 1, 0, 1),
(171, 'regular consultation', '', '2018-10-31', '09:10:00', '0:50', 1, 0, 1),
(172, 'regular consultation', '', '2018-10-31', '10:00:00', '0:50', 1, 0, 1),
(173, 'regular consultation', '', '2018-10-31', '15:00:00', '0:50', 1, 0, 1),
(174, 'regular consultation', '', '2018-10-31', '15:50:00', '0:50', 1, 0, 1),
(175, 'regular consultation', '', '2018-10-31', '15:50:00', '0:50', 1, 0, 1),
(176, 'regular consultation', '', '2018-10-31', '16:40:00', '0:50', 1, 0, 1),
(177, 'regular consultation', '', '2018-10-31', '07:30:00', '0:50', 1, 0, 1),
(178, 'regular consultation', '', '2018-10-31', '08:20:00', '0:50', 1, 0, 1),
(179, 'regular consultation', '', '2018-10-31', '11:40:00', '0:50', 1, 0, 1),
(180, 'regular consultation', '', '2018-10-31', '14:30:00', '0:20', 1, 0, 1),
(181, 'regular consultation', '', '2018-10-31', '10:25:00', '0:35', 1, 0, 1),
(182, 'regular consultation', '', '2018-11-01', '07:50:00', '0:20', 1, 0, 1),
(183, 'regular consultation', '', '2018-11-01', '08:10:00', '0:20', 1, 0, 1),
(184, 'regular consultation', '', '2018-11-01', '08:30:00', '0:20', 1, 0, 1),
(185, 'regular consultation', '', '2018-11-01', '08:50:00', '0:20', 1, 0, 1),
(186, 'regular consultation', '', '2018-11-01', '09:10:00', '0:20', 1, 0, 1),
(187, 'regular consultation', '', '2018-11-01', '09:30:00', '0:20', 1, 0, 1),
(188, 'regular consultation', '', '2018-11-01', '09:50:00', '0:20', 1, 0, 1),
(189, 'regular consultation', '', '2018-11-01', '10:10:00', '0:20', 1, 0, 1),
(190, 'regular consultation', '', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(191, 'regular consultation', '', '2018-11-01', '10:50:00', '0:20', 1, 0, 1),
(192, 'regular consultation', '', '2018-11-01', '11:10:00', '0:20', 1, 0, 1),
(193, 'regular consultation', '', '2018-11-01', '11:30:00', '0:20', 1, 0, 1),
(194, 'regular consultation', '', '2018-11-01', '11:50:00', '0:20', 1, 0, 1),
(195, 'regular consultation', '', '2018-11-01', '12:10:00', '0:20', 1, 0, 1),
(196, 'regular consultation', '', '2018-11-01', '12:30:00', '0:20', 1, 0, 1),
(197, 'regular consultation', '', '2018-11-01', '12:50:00', '0:20', 1, 0, 1),
(198, 'regular consultation', '', '2018-11-01', '13:10:00', '0:20', 1, 0, 1),
(199, 'regular consultation', '', '2018-11-01', '13:30:00', '0:20', 1, 0, 1),
(200, 'regular consultation', '', '2018-11-01', '13:50:00', '0:20', 1, 0, 1),
(201, 'regular consultation', '', '2018-11-01', '14:10:00', '0:20', 1, 0, 1),
(202, 'regular consultation', '', '2018-11-01', '14:30:00', '0:20', 1, 0, 1),
(203, 'regular consultation', '', '2018-11-01', '14:50:00', '0:20', 1, 0, 1),
(204, 'regular consultation', '', '2018-11-01', '15:10:00', '0:20', 1, 0, 1),
(205, 'regular consultation', '', '2018-11-01', '15:30:00', '0:20', 1, 0, 1),
(206, 'regular consultation', '', '2018-11-01', '15:50:00', '0:20', 1, 0, 1),
(207, 'regular consultation', '', '2018-11-01', '16:10:00', '0:20', 1, 0, 1),
(208, 'regular consultation', '', '2018-11-01', '16:30:00', '0:20', 1, 0, 1),
(209, 'regular consultation', '', '2018-11-01', '16:50:00', '0:20', 1, 0, 1),
(210, 'regular consultation', '', '2018-11-01', '17:10:00', '0:20', 1, 0, 1),
(211, 'regular consultation', '', '2018-11-01', '17:30:00', '0:20', 1, 0, 1),
(212, 'regular consultation', '', '2018-11-01', '17:50:00', '0:20', 1, 0, 1),
(213, 'regular consultation', '', '2018-11-01', '18:10:00', '0:20', 1, 0, 1),
(214, 'regular consultation', '', '2018-11-01', '18:30:00', '0:20', 1, 0, 1),
(215, 'regular consultation', '', '2018-11-01', '18:50:00', '0:20', 1, 0, 1),
(216, 'regular consultation', '', '2018-11-01', '19:10:00', '0:20', 1, 0, 1),
(217, 'regular consultation', '', '2018-11-01', '07:30:00', '0:20', 1, 0, 1),
(218, 'regular consultation', '', '2018-11-02', '07:30:00', '0:20', 1, 0, 1),
(219, 'regular consultation', '', '2018-11-02', '07:50:00', '0:20', 1, 0, 1),
(220, 'regular consultation', '', '2018-11-02', '12:05:00', '0:20', 1, 0, 1),
(221, 'regular consultation', '', '2018-11-02', '12:25:00', '0:20', 1, 0, 1),
(222, 'regular consultation', '', '2018-11-02', '12:45:00', '0:20', 1, 0, 1),
(223, 'regular consultation', '', '2018-11-02', '13:05:00', '0:20', 1, 0, 1),
(224, 'regular consultation', '', '2018-11-02', '13:25:00', '0:20', 1, 0, 1),
(225, 'regular consultation', '', '2018-11-02', '13:45:00', '0:20', 1, 0, 1),
(226, 'regular consultation', '', '2018-11-02', '14:05:00', '0:20', 1, 0, 1),
(227, 'regular consultation', '', '2018-11-02', '14:25:00', '0:20', 1, 0, 1),
(228, 'regular consultation', '', '2018-11-02', '14:45:00', '0:20', 1, 0, 1),
(229, 'regular consultation', '', '2018-11-02', '15:05:00', '0:20', 1, 0, 1),
(230, 'regular consultation', '', '2018-11-02', '15:25:00', '0:20', 1, 0, 1),
(231, 'regular consultation', '', '2018-11-02', '15:45:00', '0:20', 1, 0, 1),
(232, 'regular consultation', '', '2018-11-02', '16:05:00', '0:20', 1, 0, 1),
(233, 'regular consultation', '', '2018-11-02', '16:25:00', '0:20', 1, 0, 1),
(234, 'regular consultation', '', '2018-11-02', '16:45:00', '0:20', 1, 0, 1),
(235, 'regular consultation', '', '2018-11-02', '17:05:00', '0:20', 1, 0, 1),
(236, 'regular consultation', '', '2018-11-02', '17:25:00', '0:20', 1, 0, 1),
(237, 'regular consultation', '', '2018-11-02', '17:45:00', '0:20', 1, 0, 1),
(238, 'regular consultation', '', '2018-11-02', '18:05:00', '0:20', 1, 0, 1),
(239, 'regular consultation', '', '2018-11-02', '18:25:00', '0:20', 1, 0, 1),
(240, 'regular consultation', '', '2018-11-02', '18:45:00', '0:20', 1, 0, 1),
(241, 'regular consultation', '', '2018-11-02', '19:05:00', '0:20', 1, 0, 1),
(242, 'regular consultation', '', '2018-10-31', '08:45:00', '0:20', 1, 0, 1),
(243, 'regular consultation', '', '2018-10-31', '09:05:00', '0:20', 1, 0, 1),
(244, 'regular consultation', '', '2018-10-31', '09:25:00', '0:20', 1, 0, 1),
(245, 'regular consultation', '', '2018-10-31', '09:45:00', '0:20', 1, 0, 1),
(246, 'regular consultation', '', '2018-10-31', '10:05:00', '0:20', 1, 0, 1),
(247, 'regular consultation', '', '2018-10-31', '10:25:00', '0:20', 1, 0, 1),
(248, 'regular consultation', '', '2018-10-31', '10:45:00', '0:20', 1, 0, 1),
(249, 'regular consultation', '', '2018-10-31', '11:05:00', '0:20', 1, 0, 1),
(250, 'regular consultation', '', '2018-10-31', '11:25:00', '0:20', 1, 0, 1),
(251, 'regular consultation', '', '2018-10-31', '11:45:00', '0:20', 1, 0, 1),
(252, 'regular consultation', '', '2018-10-31', '12:05:00', '0:20', 1, 0, 1),
(253, 'regular consultation', '', '2018-10-31', '12:25:00', '0:20', 1, 0, 1),
(254, 'regular consultation', '', '2018-10-31', '12:45:00', '0:20', 1, 0, 1),
(255, 'regular consultation', '', '2018-10-31', '13:05:00', '0:20', 1, 0, 1),
(256, 'regular consultation', '', '2018-10-31', '13:25:00', '0:20', 1, 0, 1),
(257, 'regular consultation', '', '2018-10-31', '13:45:00', '0:20', 1, 0, 1),
(258, 'regular consultation', '', '2018-10-31', '14:05:00', '0:20', 1, 0, 1),
(259, 'regular consultation', '', '2018-10-31', '14:25:00', '0:20', 1, 0, 1),
(260, 'regular consultation', '', '2018-10-31', '14:45:00', '0:20', 1, 0, 1),
(261, 'regular consultation', '', '2018-10-31', '15:05:00', '0:20', 1, 0, 1),
(262, 'regular consultation', '', '2018-10-31', '15:25:00', '0:20', 1, 0, 1),
(263, 'regular consultation', '', '2018-10-31', '15:45:00', '0:20', 1, 0, 1),
(264, 'regular consultation', '', '2018-10-31', '16:05:00', '0:20', 1, 0, 1),
(265, 'regular consultation', '', '2018-10-31', '16:25:00', '0:20', 1, 0, 1),
(266, 'regular consultation', '', '2018-10-31', '16:45:00', '0:20', 1, 0, 1),
(267, 'regular consultation', '', '2018-10-31', '17:05:00', '0:20', 1, 0, 1),
(268, 'regular consultation', '', '2018-10-31', '17:25:00', '0:20', 1, 0, 1),
(269, 'regular consultation', '', '2018-10-31', '17:45:00', '0:20', 1, 0, 1),
(270, 'regular consultation', '', '2018-10-31', '18:05:00', '0:20', 1, 0, 1),
(271, 'regular consultation', '', '2018-10-31', '18:25:00', '0:20', 1, 0, 1),
(272, 'regular consultation', '', '2018-10-31', '18:45:00', '0:20', 1, 0, 1),
(273, 'regular consultation', '', '2018-10-31', '19:05:00', '0:20', 1, 0, 1),
(274, 'regular consultation', '', '2018-10-31', '07:30:00', '12:0', 1, 0, 1),
(275, 'regular consultation', '', '2018-10-31', '07:30:00', '0:0', 1, 0, 1),
(276, 'regular consultation', '', '2018-10-31', '07:30:00', '0:0', 1, 0, 1),
(277, 'regular consultation', '', '2018-11-01', '07:30:00', '12:0', 1, 0, 1),
(278, 'regular consultation', '', '2018-11-01', '07:30:00', '0:0', 1, 0, 1),
(279, 'regular consultation', '', '2018-11-01', '07:30:00', '0:0', 1, 0, 1),
(280, 'regular consultation', '', '2018-10-31', '19:25:00', '0:5', 1, 0, 1),
(281, 'regular consultation', '', '2018-10-31', '07:55:00', '0:25', 1, 0, 1),
(282, 'regular consultation', '', '2018-11-01', '07:30:00', '12:0', 1, 0, 1),
(283, 'regular consultation', '', '2018-11-02', '07:30:00', '0:20', 1, 0, 1),
(284, 'regular consultation', '', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(285, 'regular consultation', '', '2018-11-01', '09:30:00', '0:20', 1, 0, 1),
(286, 'regular consultation', 'reg appointment', '2018-11-01', '10:50:00', '0:20', 1, 0, 1),
(287, 'regular consultation', 'reg appointment', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(288, 'regular consultation', 'reg appointment', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(289, 'regular consultation', 'reg appointment', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(290, 'regular consultation', 'reg appointment', '2018-11-01', '11:10:00', '0:20', 1, 0, 1),
(291, 'regular consultation', 'reg appointment', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(292, 'regular consultation', 'reg appointment', '2018-11-01', '10:50:00', '0:20', 1, 0, 1),
(293, 'regular consultation', 'reg appointment', '2018-11-01', '10:30:00', '0:20', 1, 0, 1),
(294, 'regular consultation', 'reg appointment', '2018-11-01', '11:10:00', '0:20', 1, 0, 1),
(295, 'regular consultation', 'reg appointment', '2018-11-01', '11:10:00', '0:20', 1, 0, 1),
(296, 'regular consultation', 'reg appointment', '2018-11-01', '10:50:00', '0:20', 1, 0, 1),
(297, 'regular consultation', 'reg appointment', '2018-11-01', '10:50:00', '0:20', 1, 0, 1),
(298, 'regular consultation', 'reg appointment', '2018-11-01', '11:10:00', '0:20', 1, 0, 1),
(299, 'regular consultation', 'reg appointment', '2018-11-01', '16:30:00', '0:20', 1, 0, 1),
(300, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(301, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(302, 'regular consultation', 'reg appointment', '2018-11-01', '16:30:00', '0:20', 1, 0, 1),
(303, 'regular consultation', 'reg appointment', '2018-11-01', '16:50:00', '0:20', 1, 0, 1),
(304, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(305, 'regular consultation', 'reg appointment', '2018-11-01', '16:30:00', '0:20', 1, 0, 1),
(306, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(307, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(308, 'regular consultation', 'reg appointment', '2018-11-01', '16:50:00', '0:20', 1, 0, 1),
(309, 'regular consultation', 'reg appointment', '2018-11-01', '17:10:00', '0:20', 1, 0, 1),
(310, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(311, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(312, 'regular consultation', 'reg appointment', '2018-11-03', '09:10:00', '0:20', 1, 0, 1),
(313, 'regular consultation', 'reg appointment', '2018-11-03', '09:10:00', '0:20', 1, 0, 1),
(314, 'regular consultation', 'reg appointment', '2018-11-03', '09:10:00', '0:20', 1, 0, 1),
(315, 'regular consultation', 'reg appointment', '2018-11-03', '09:10:00', '0:20', 1, 0, 1),
(316, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(317, 'regular consultation', 'reg appointment', '2018-11-03', '09:30:00', '0:20', 1, 0, 1),
(318, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(319, 'regular consultation', 'reg appointment', '2018-11-03', '09:10:00', '0:20', 1, 0, 1),
(320, 'regular consultation', 'reg appointment', '2018-11-03', '07:30:00', '0:20', 1, 0, 1),
(321, 'regular consultation', 'reg appointment', '2018-11-03', '09:10:00', '0:20', 1, 0, 1),
(322, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(323, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(324, 'regular consultation', 'reg appointment', '2018-11-03', '09:30:00', '0:20', 1, 0, 1),
(325, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(326, 'regular consultation', 'reg appointment', '2018-11-03', '07:30:00', '0:20', 1, 0, 1),
(327, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(328, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(329, 'regular consultation', 'reg appointment', '2018-11-03', '07:50:00', '0:20', 1, 0, 1),
(330, 'regular consultation', 'reg appointment', '2018-11-03', '09:30:00', '0:20', 1, 0, 1),
(331, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(332, 'regular consultation', 'reg appointment', '2018-11-03', '09:50:00', '0:20', 1, 0, 1),
(333, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(334, 'regular consultation', 'reg appointment', '2018-11-05', '08:50:00', '0:20', 1, 0, 1),
(335, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(336, 'regular consultation', 'reg appointment', '2018-11-05', '09:10:00', '0:20', 1, 0, 1),
(337, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(338, 'regular consultation', 'reg appointment', '2018-11-07', '13:30:00', '0:20', 1, 0, 1),
(339, 'regular consultation', 'reg appointment', '0000-00-00', '00:00:00', '', 1, 0, 1),
(341, 'Maladie', '123', '2018-11-10', '07:30:00', '0:40', 3, 0, 1),
(342, 'Maladie', '123', '2018-11-10', '07:30:00', '0:20', 3, 0, 1),
(343, 'Maladie', '123', '0000-00-00', '07:30:00', '0:20', 3, 0, 1),
(344, 'Maladie', 'meet with Lucas', '2018-11-11', '13:40:00', '0:20', 1, 0, 1),
(345, 'regular consultation', 'reg appointment', '2018-12-04', '10:10:00', '0:20', 1, 0, 1),
(346, 'regular consultation', 'reg appointment', '2018-12-05', '14:50:00', '0:20', 1, 0, 1),
(347, 'regular consultation', 'reg appointment', '2018-12-05', '15:10:00', '0:20', 1, 0, 1),
(348, 'regular consultation', 'reg appointment', '2018-12-05', '15:30:00', '0:20', 1, 0, 1),
(349, 'regular consultation', 'reg appointment', '2018-12-05', '15:50:00', '0:20', 1, 0, 1),
(350, 'regular consultation', 'reg appointment', '2018-12-05', '16:10:00', '0:20', 1, 0, 1),
(351, 'regular consultation', 'reg appointment', '2018-12-05', '16:30:00', '0:20', 1, 0, 1),
(352, 'regular consultation', 'reg appointment', '2018-12-05', '16:50:00', '0:20', 1, 0, 1),
(353, 'regular consultation', 'reg appointment', '2018-12-05', '17:10:00', '0:20', 1, 0, 1),
(354, 'regular consultation', 'reg appointment', '2018-12-05', '14:50:00', '0:20', 1, 0, 1),
(355, 'regular consultation', 'reg appointment', '2018-12-05', '15:10:00', '0:20', 1, 0, 1),
(356, 'regular consultation', 'reg appointment', '2018-12-05', '15:30:00', '0:20', 1, 0, 1),
(357, 'regular consultation', 'reg appointment', '2018-12-05', '17:30:00', '0:20', 1, 0, 1),
(358, 'regular consultation', 'reg appointment', '2018-12-05', '17:50:00', '0:20', 1, 0, 1),
(359, 'regular consultation', 'reg appointment', '2018-12-05', '18:10:00', '0:20', 1, 0, 1),
(360, 'regular consultation', 'reg appointment', '2018-12-05', '18:30:00', '0:20', 1, 0, 1),
(361, 'regular consultation', 'reg appointment', '2018-12-05', '18:50:00', '0:20', 1, 0, 1),
(362, 'regular consultation', 'reg appointment', '2018-12-05', '19:10:00', '0:20', 1, 0, 1),
(363, 'regular consultation', 'reg appointment', '2018-12-06', '14:50:00', '0:20', 1, 0, 1),
(364, 'dasfjoisjf', 'ddssfd', '2018-12-07', '15:00:00', '00:20', 1, 0, 1),
(365, 'Test', 'test', '2018-12-10', '11:00:00', '00:20', 1, 0, 1),
(366, 'Test', 'test', '2018-12-10', '12:00:00', '00:20', 1, 0, 2),
(367, 'regular consultation', 'reg appointment', '2018-12-10', '12:20:00', '0:20', 1, 0, 1),
(368, 'regular consultation', 'reg appointment', '2018-12-10', '12:40:00', '0:20', 1, 0, 1),
(369, 'regular consultation', 'reg appointment', '2018-12-10', '14:20:00', '0:20', 1, 0, 2),
(370, 'regular consultation', 'reg appointment', '2018-12-10', '14:40:00', '0:20', 1, 0, 2),
(371, 'regular consultation', 'reg appointment', '2018-12-10', '13:10:00', '0:20', 1, 0, 3),
(372, 'regular consultation', 'reg appointment', '2018-12-10', '13:50:00', '0:20', 1, 0, 3),
(373, 'regular consultation', 'reg appointment', '2018-12-10', '15:10:00', '0:20', 1, 0, 4),
(374, 'regular consultation', 'reg appointment', '2018-12-10', '15:30:00', '0:20', 1, 0, 4),
(375, 'regular consultation', 'reg appointment', '2018-12-10', '14:40:00', '0:20', 1, 0, 1),
(376, 'regular consultation', 'reg appointment', '2018-12-10', '15:00:00', '0:20', 1, 0, 1),
(377, 'regular consultation', 'reg appointment', '2018-12-10', '15:20:00', '0:20', 1, 0, 1),
(378, 'regular consultation', 'reg appointment', '2018-12-11', '09:50:00', '0:20', 1, 0, 1),
(379, 'regular consultation', 'reg appointment', '2018-12-11', '10:10:00', '0:20', 1, 0, 1),
(380, 'regular consultation', 'reg appointment', '2018-12-11', '10:30:00', '0:20', 1, 0, 1),
(381, 'regular consultation', 'reg appointment', '2018-12-11', '10:50:00', '0:20', 1, 0, 1),
(382, 'regular consultation', 'reg appointment', '2018-12-11', '10:50:00', '0:20', 1, 0, 4),
(383, 'regular consultation', 'reg appointment', '2018-12-11', '11:30:00', '0:20', 1, 0, 4),
(384, 'regular consultation', 'reg appointment', '2018-12-11', '10:50:00', '0:20', 1, 0, 3),
(385, 'regular consultation', 'reg appointment', '2018-12-11', '11:50:00', '0:20', 1, 0, 3),
(386, 'regular consultation', 'reg appointment', '2018-12-11', '11:10:00', '0:20', 1, 0, 2),
(387, 'regular consultation', 'reg appointment', '2018-12-11', '11:10:00', '0:20', 1, 0, 1),
(388, 'regular consultation', 'reg appointment', '2018-12-11', '11:30:00', '0:20', 1, 0, 1),
(389, 'regular consultation', 'reg appointment', '2018-12-11', '11:50:00', '0:20', 1, 0, 1),
(390, 'regular consultation', 'reg appointment', '2018-12-11', '14:10:00', '0:20', 1, 0, 1),
(391, 'regular consultation', 'reg appointment', '2018-12-13', '12:50:00', '0:20', 1, 0, 1),
(392, 'regular consultation', 'reg appointment', '2018-12-13', '12:50:00', '0:20', 1, 0, 1),
(393, 'regular consultation', 'reg appointment', '2018-12-13', '12:50:00', '0:20', 1, 0, 1),
(394, 'regular consultation', 'reg appointment', '2018-12-13', '12:50:00', '0:20', 1, 0, 1),
(395, 'regular consultation', 'reg appointment', '2018-12-13', '12:50:00', '0:20', 1, 0, 1),
(396, 'regular consultation', 'reg appointment', '2018-12-14', '12:10:00', '0:20', 1, 0, 1),
(397, 'regular consultation', 'reg appointment', '2018-12-14', '12:50:00', '0:20', 1, 0, 1),
(398, 'regular consultation', 'reg appointment', '2018-12-14', '13:30:00', '0:20', 1, 0, 1),
(399, 'regular consultation', 'reg appointment', '2018-12-14', '12:30:00', '0:20', 1, 0, 1),
(400, 'regular consultation', 'reg appointment', '2018-12-14', '13:10:00', '0:20', 1, 0, 1),
(401, 'regular consultation', 'reg appointment', '2018-12-14', '13:50:00', '0:20', 1, 0, 1),
(402, 'regular consultation', 'reg appointment', '2018-12-14', '14:10:00', '0:20', 1, 0, 1),
(403, 'regular consultation', 'reg appointment', '2018-12-14', '14:30:00', '0:20', 1, 0, 1),
(404, 'regular consultation', 'reg appointment', '2018-12-14', '14:50:00', '0:20', 1, 0, 1),
(405, 'regular consultation', 'reg appointment', '2018-12-14', '15:10:00', '0:20', 1, 0, 1),
(406, 'regular consultation', 'reg appointment', '2018-12-14', '15:30:00', '0:20', 1, 0, 1),
(407, 'regular consultation', 'reg appointment', '2018-12-14', '15:50:00', '0:20', 1, 0, 1),
(408, 'regular consultation', 'reg appointment', '2018-12-14', '16:10:00', '0:20', 1, 0, 1),
(409, 'Consultation', 'Consultation', '2018-12-14', '16:30:00', '0:20', 1, 0, 1),
(410, 'Consultation', 'Consultation', '2018-12-14', '17:10:00', '0:20', 1, 0, 1),
(411, 'Consultation', 'Consultation', '2018-12-14', '13:10:00', '0:20', 1, 0, 4),
(412, 'Consultation', 'Consultation', '2018-12-14', '13:50:00', '0:20', 1, 0, 4),
(413, 'Consultation', 'Consultation', '2018-12-14', '13:10:00', '0:20', 1, 0, 3),
(414, 'Consultation', 'Consultation', '2018-12-14', '16:50:00', '0:20', 1, 0, 1),
(415, 'Consultation', 'Consultation', '2018-12-14', '17:30:00', '0:20', 1, 0, 1),
(416, 'Consultation', 'Consultation', '2018-12-14', '17:50:00', '0:20', 1, 0, 1),
(417, 'Consultation', 'Consultation', '2018-12-14', '13:50:00', '0:20', 1, 0, 3),
(418, 'Consultation', 'Consultation', '2018-12-14', '14:30:00', '0:20', 1, 0, 3),
(419, 'Consultation', 'Consultation', '2018-12-14', '14:10:00', '0:20', 1, 0, 4),
(420, 'Consultation', 'Consultation', '2018-12-14', '14:30:00', '0:20', 1, 0, 4),
(421, 'Consultation', 'Consultation', '2018-12-14', '14:50:00', '0:20', 1, 0, 3),
(422, 'Consultation', 'Consultation', '2018-12-14', '15:50:00', '0:20', 1, 0, 4),
(423, 'Consultation', 'Consultation', '2018-12-14', '14:50:00', '0:20', 1, 0, 4),
(424, 'Consultation', 'Consultation', '2018-12-14', '16:10:00', '0:20', 1, 0, 4),
(425, 'Consultation', 'Consultation', '2018-12-21', '09:30:00', '0:20', 1, 0, 1),
(426, 'Consultation', 'Consultation', '2018-12-21', '10:10:00', '0:20', 1, 0, 1),
(427, 'Consultation', 'Consultation', '2018-12-21', '10:50:00', '0:20', 1, 0, 1),
(428, 'Consultation', 'Consultation', '2018-12-27', '07:30:00', '0:20', 1, 0, 1),
(429, 'Consultation', 'Consultation', '2018-12-27', '07:50:00', '0:20', 1, 0, 1),
(430, 'Consultation', 'Consultation', '2018-12-27', '08:10:00', '0:20', 1, 0, 1),
(431, 'Consultation', 'Consultation', '2019-01-08', '12:10:00', '0:20', 1, 0, 1),
(432, NULL, '0', '2019-02-20', '00:00:03', '0:30', 1, 1, 2),
(433, NULL, '0', '2019-02-20', '00:00:03', '23:30:00', 1, 1, 2),
(434, NULL, '0', '2019-02-20', '00:00:03', '23:30:00', 1, 1, 2),
(435, NULL, '0', '2019-02-20', '00:00:03', '23:30:00', 1, 1, 2),
(436, NULL, '0', '2019-02-20', '00:00:03', '23:30:00', 1, 1, 2),
(437, NULL, '0', '2019-02-20', '00:00:03', '23:30:00', 1, 1, 2),
(438, NULL, '0', '2019-02-20', '00:00:03', '23:30:00', 1, 1, 2),
(439, NULL, '0', '2019-02-20', '300:00:00', '23:30', 1, 1, 2),
(440, NULL, '0', '2019-02-20', '03:00:00', '23:30', 1, 1, 2),
(441, NULL, '0', '2019-02-20', '03:00:00', '00:30:00', 1, 1, 2),
(442, NULL, '0', '2019-02-20', '03:00:00', '00:30:00', 1, 0, 2),
(443, NULL, '0', '2019-02-20', '03:00:00', '00:30:00', 1, 1, 2),
(444, NULL, '0', '2019-02-20', '03:00:00', '00:00:00', 1, 0, 2),
(445, NULL, 'Test', '2019-02-20', '03:00:00', '00:30:00', 2, 0, 2),
(446, NULL, '0', '2019-02-20', '03:00:00', '00:30:00', 1, 1, 2),
(447, NULL, '0', '2019-02-20', '03:30:00', '00:20:00', 1, 0, 12),
(448, NULL, '0', '2019-02-20', '03:00:00', '00:50:00', 1, 0, 2),
(449, NULL, '0', '2019-02-20', '03:00:00', '00:30:00', 1, 0, 2),
(450, NULL, '0', '2019-02-20', '03:00:00', '00:30:00', 1, 0, 2),
(451, NULL, '0', '2019-02-22', '03:03:00', NULL, 1, 0, 2),
(452, NULL, '0', '2019-02-22', '03:03:00', '00:47:00', 1, 0, 2),
(453, NULL, '0', '2019-02-22', '03:30:00', '00:30:00', 1, 0, 2),
(454, NULL, '0', '2019-02-22', '03:30:00', '23:30:00', 1, 0, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_appointmentplace`
--

CREATE TABLE `t_appointmentplace` (
  `fkAppointment` int(11) NOT NULL,
  `fkAddress` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_appointmentplace`
--

INSERT INTO `t_appointmentplace` (`fkAppointment`, `fkAddress`) VALUES
(433, 1),
(438, 332),
(439, 332),
(440, 332),
(441, 332),
(442, 473),
(443, 530),
(444, 2),
(445, 2),
(446, 2),
(447, 2),
(448, 1),
(451, 2),
(452, 2),
(453, 2),
(454, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_appointmenttype`
--

CREATE TABLE `t_appointmenttype` (
  `idAppointmentType` int(11) NOT NULL,
  `appName` varchar(255) NOT NULL,
  `appColor` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_appointmenttype`
--

INSERT INTO `t_appointmenttype` (`idAppointmentType`, `appName`, `appColor`) VALUES
(1, 'Consultations', '#bcbccb'),
(2, 'Professional', '#2097f0'),
(3, 'External visits', '#1eb609'),
(4, 'Private', '#af52da');

-- --------------------------------------------------------

--
-- Table structure for table `t_bankaccount`
--

CREATE TABLE `t_bankaccount` (
  `idBankAccount` int(11) NOT NULL,
  `fkMedicalActor` int(11) NOT NULL,
  `fkMedicalEstablishment` int(11) NOT NULL,
  `fkContact` int(11) NOT NULL,
  `banaccIBAN` varchar(255) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_bankaccount`
--

INSERT INTO `t_bankaccount` (`idBankAccount`, `fkMedicalActor`, `fkMedicalEstablishment`, `fkContact`, `banaccIBAN`) VALUES
(1, 1, 1, 1, 'sddafdafsasafsdasdfasdas'),
(2, 2, 2, 1, '09327390354305');

-- --------------------------------------------------------

--
-- Table structure for table `t_belontoprescription`
--

CREATE TABLE `t_belontoprescription` (
  `idMedicament` int(11) NOT NULL,
  `idMedicalPrescription` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_calendar`
--

CREATE TABLE `t_calendar` (
  `idCalendar` int(11) NOT NULL,
  `calName` varchar(255) NOT NULL,
  `fkUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_calendar`
--

INSERT INTO `t_calendar` (`idCalendar`, `calName`, `fkUser`) VALUES
(1, 'Principal', 2),
(2, 'Secondaire', 2),
(3, 'Principal', 1),
(4, 'Principal', 12);

-- --------------------------------------------------------

--
-- Table structure for table `t_chronicdisease`
--

CREATE TABLE `t_chronicdisease` (
  `idChronicDisease` smallint(6) NOT NULL,
  `chrdisName` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_chronicdisease`
--

INSERT INTO `t_chronicdisease` (`idChronicDisease`, `chrdisName`) VALUES
(1, 'Fiver'),
(2, 'fiv');

-- --------------------------------------------------------

--
-- Table structure for table `t_cities`
--

CREATE TABLE `t_cities` (
  `id` int(4) NOT NULL,
  `name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_cities`
--

INSERT INTO `t_cities` (`id`, `name`) VALUES
(1, 'Zurich'),
(2, 'Geneva'),
(3, 'Basel'),
(4, 'Lausanne'),
(5, 'Bern'),
(6, 'Winterthur'),
(7, 'Lucerne'),
(8, 'St. Gallen'),
(9, 'Lugano'),
(10, 'Biel/Bienne'),
(11, 'Thun'),
(12, 'Köniz'),
(13, 'La Chaux-de-Fonds'),
(14, 'Fribourg'),
(15, 'Schaffhausen'),
(16, 'Vernier'),
(17, 'Chur'),
(18, 'Sion'),
(19, 'Uster'),
(20, 'Neuchâtel'),
(21, 'Boston'),
(22, 'Irvington'),
(23, 'Dobbs Ferry'),
(24, 'Wolverhampton'),
(25, 'Toronto'),
(26, 'Đống Đa'),
(27, 'Kamakura'),
(28, 'Arlington'),
(29, 'New York'),
(30, 'Honolulu'),
(31, 'Philadelphia'),
(32, 'Meyrin');

-- --------------------------------------------------------

--
-- Table structure for table `t_clinicalsigns`
--

CREATE TABLE `t_clinicalsigns` (
  `idClinicalsigns` int(6) NOT NULL,
  `cliDescription` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_clinicalsigns`
--

INSERT INTO `t_clinicalsigns` (`idClinicalsigns`, `cliDescription`) VALUES
(1, 'Array'),
(2, 'qwdqwd'),
(3, 'fr23f'),
(4, 'gtgt'),
(5, 'wef'),
(6, 'wer'),
(7, 'qwd'),
(8, 'ргш'),
(9, 'к23к'),
(10, '2'),
(11, '3к'),
(12, '23'),
(13, 'к'),
(14, '23к'),
(15, 'ХУЙ'),
(16, 'живот болит'),
(17, 'bad horoscope');

-- --------------------------------------------------------

--
-- Table structure for table `t_clinicalsignsbelongtoconsultations`
--

CREATE TABLE `t_clinicalsignsbelongtoconsultations` (
  `fkClinicalsigns` int(6) NOT NULL,
  `fkConsultations` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_clinicalsignsbelongtoconsultations`
--

INSERT INTO `t_clinicalsignsbelongtoconsultations` (`fkClinicalsigns`, `fkConsultations`) VALUES
(5, 28),
(6, 28),
(16, 31),
(15, 30),
(5, 34),
(17, 43);

-- --------------------------------------------------------

--
-- Table structure for table `t_cliniquebelongtoappointment`
--

CREATE TABLE `t_cliniquebelongtoappointment` (
  `id` int(11) NOT NULL,
  `idAppointment` int(11) NOT NULL,
  `idAppointment_t_appointment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_cliniques`
--

CREATE TABLE `t_cliniques` (
  `idCliniques` int(4) NOT NULL,
  `cliName` varchar(50) NOT NULL,
  `cliCity` int(4) NOT NULL,
  `cliMainPhone` int(11) NOT NULL,
  `cliPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_cliniques`
--

INSERT INTO `t_cliniques` (`idCliniques`, `cliName`, `cliCity`, `cliMainPhone`, `cliPhoto`) VALUES
(1, 'La Prairie1', 1, 2147483647, ''),
(2, 'La Prairie2', 1, 2147483647, ''),
(3, 'La Prairie3', 1, 2147483647, ''),
(4, 'La Prairie4', 8, 2147483647, ''),
(5, 'La Prairie5', 19, 2147483647, ''),
(6, 'La Prairie6', 18, 2147483647, ''),
(7, 'Aquamed1', 13, 2147483647, ''),
(8, 'Aquamed2', 19, 2147483647, ''),
(9, 'Aquamed3', 11, 2147483647, ''),
(10, 'Aquamed4', 12, 2147483647, ''),
(11, 'Aquamed5', 18, 2147483647, ''),
(12, 'Aquamed6', 19, 2147483647, ''),
(13, 'Providence1', 6, 2147483647, ''),
(14, 'Providence2', 7, 2147483647, ''),
(15, 'Providence3', 1, 2147483647, ''),
(16, 'Providence4', 1, 2147483647, ''),
(17, 'Providence5', 18, 2147483647, ''),
(18, 'Providence6', 20, 2147483647, ''),
(19, 'Clinique Suisse Montreux1', 19, 2147483647, ''),
(20, 'Clinique Suisse Montreux2', 20, 2147483647, ''),
(21, 'Clinique Suisse Montreux3', 3, 2147483647, ''),
(22, 'Clinique Suisse Montreux4', 8, 2147483647, ''),
(23, 'Clinique Suisse Montreux5', 13, 2147483647, ''),
(24, 'Clinique Suisse Montreux6', 19, 2147483647, ''),
(25, 'CIC Riviera', 11, 2147483647, ''),
(26, 'CIC Chablais', 12, 2147483647, ''),
(27, 'ASMAV', 19, 2147483647, ''),
(28, 'Clinique Cecil', 13, 2147483647, ''),
(29, 'Fondation de nant', 8, 2147483647, ''),
(30, 'GSMN', 15, 2147483647, '');

-- --------------------------------------------------------

--
-- Table structure for table `t_config`
--

CREATE TABLE `t_config` (
  `idConfig` int(11) NOT NULL,
  `conAnkerID` varchar(255) NOT NULL,
  `conAnkerKey` varchar(255) NOT NULL,
  `conEstablishmentName` varchar(255) NOT NULL,
  `conLicenseOwner` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_config`
--

INSERT INTO `t_config` (`idConfig`, `conAnkerID`, `conAnkerKey`, `conEstablishmentName`, `conLicenseOwner`) VALUES
(1, 'testID', 'testKey', 'Cabinet Medical du bristol', 'Dr. Gilles Tardieu'),
(2, 'agagarerae', 'arga', 'ragrae', 'Dr. Riddley');

-- --------------------------------------------------------

--
-- Table structure for table `t_consultations`
--

CREATE TABLE `t_consultations` (
  `idConsultations` int(6) NOT NULL,
  `idPatient` int(6) NOT NULL,
  `idAppointment` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_consultations`
--

INSERT INTO `t_consultations` (`idConsultations`, `idPatient`, `idAppointment`) VALUES
(7, 38, 334),
(8, 38, 334),
(11, 1, 338),
(15, 1, 332),
(17, 1, 345),
(27, 7, 357),
(28, 1, 415),
(29, 1, 421),
(30, 1, 417),
(31, 1, 418),
(32, 17, 425),
(33, 91, 427),
(34, 17, 428),
(35, 11, 429),
(43, 17, 431);

-- --------------------------------------------------------

--
-- Table structure for table `t_contact`
--

CREATE TABLE `t_contact` (
  `idContact` int(11) NOT NULL,
  `conName` varchar(100) NOT NULL,
  `conLastName` varchar(100) DEFAULT NULL,
  `conGender` varchar(100) DEFAULT NULL,
  `conMainPhone` varchar(20) DEFAULT NULL,
  `conMainFax` varchar(100) DEFAULT NULL,
  `conMainMail` varchar(100) DEFAULT NULL,
  `conPersonalPhone` varchar(20) DEFAULT NULL,
  `conPersonalFax` varchar(100) DEFAULT NULL,
  `conPersonalMail` varchar(100) DEFAULT NULL,
  `conCanSendMail` tinyint(1) DEFAULT NULL,
  `conProfilePic` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_contact`
--

INSERT INTO `t_contact` (`idContact`, `conName`, `conLastName`, `conGender`, `conMainPhone`, `conMainFax`, `conMainMail`, `conPersonalPhone`, `conPersonalFax`, `conPersonalMail`, `conCanSendMail`, `conProfilePic`) VALUES
(1, 'Anthony', 'Doe', 'M', '7894561230', '0123456789', 'anthony@doe.com', '', '', '', 1, NULL),
(6, 'Company 1', NULL, NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(9, 'Company 2', NULL, NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(10, 'Unemploy Company 1', NULL, NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(11, 'Company 3', NULL, NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(12, 'Company 4', NULL, NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(13, 'Company 5', NULL, NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(14, 'Gian', 'F', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(15, 'Gian', 'F', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(16, 'Gian', 'F', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(17, 'Gian', 'F', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(18, 'Val', 'Gian', NULL, '111', NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_contactbelongtoappointment`
--

CREATE TABLE `t_contactbelongtoappointment` (
  `fkContact` int(11) NOT NULL,
  `fkAppointment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_contactbelongtoappointment`
--

INSERT INTO `t_contactbelongtoappointment` (`fkContact`, `fkAppointment`) VALUES
(18, 449),
(18, 450);

-- --------------------------------------------------------

--
-- Table structure for table `t_contacthasinsurance`
--

CREATE TABLE `t_contacthasinsurance` (
  `fkContact` int(11) NOT NULL,
  `fkInsurance` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_contacthasinsurance`
--

INSERT INTO `t_contacthasinsurance` (`fkContact`, `fkInsurance`) VALUES
(6, 3),
(6, 4),
(9, 16),
(9, 1),
(10, 1),
(10, 6),
(10, 11),
(11, 1),
(11, 4),
(12, 6),
(12, 7),
(13, 20),
(13, 8);

-- --------------------------------------------------------

--
-- Table structure for table `t_contacthastype`
--

CREATE TABLE `t_contacthastype` (
  `fkContact` int(11) NOT NULL,
  `fkContactType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_contacthastype`
--

INSERT INTO `t_contacthastype` (`fkContact`, `fkContactType`) VALUES
(1, 1),
(6, 3),
(9, 3),
(10, 4),
(11, 3),
(12, 3),
(13, 3),
(17, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_contacttype`
--

CREATE TABLE `t_contacttype` (
  `idContactType` int(11) NOT NULL,
  `contypeName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_contacttype`
--

INSERT INTO `t_contacttype` (`idContactType`, `contypeName`) VALUES
(1, 'AI Office'),
(2, 'Other type of contact'),
(3, 'Company'),
(4, 'Unemployment Company');

-- --------------------------------------------------------

--
-- Table structure for table `t_country`
--

CREATE TABLE `t_country` (
  `idCountry` int(11) NOT NULL,
  `couName` varchar(100) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_country`
--

INSERT INTO `t_country` (`idCountry`, `couName`) VALUES
(1, 'United States'),
(2, 'United Kingdom'),
(3, 'Canada'),
(4, 'Vietnam'),
(5, 'Japan'),
(6, 'Argentina'),
(7, 'India'),
(8, 'Switzerland');

-- --------------------------------------------------------

--
-- Table structure for table `t_diagnostics`
--

CREATE TABLE `t_diagnostics` (
  `idDiagnostics` int(6) NOT NULL,
  `diaDescription` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_diagnosticsbelongtoconsultations`
--

CREATE TABLE `t_diagnosticsbelongtoconsultations` (
  `fkDiagnostics` int(6) NOT NULL,
  `fkConsultations` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_dispatchandinsurance`
--

CREATE TABLE `t_dispatchandinsurance` (
  `idDispatchAndInsurance` int(11) NOT NULL,
  `disandinsPatientCopy` tinyint(1) NOT NULL,
  `disandinsPatientOriginalBill` tinyint(1) NOT NULL,
  `disandinsPatientReceipt` tinyint(1) NOT NULL,
  `disandinsInsurance` tinyint(1) NOT NULL,
  `disandinsMail` tinyint(1) NOT NULL,
  `disandinsAnker` tinyint(1) NOT NULL,
  `fkInsurance` int(11) NOT NULL,
  `fkRefundType` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_dispatchandinsurance`
--

INSERT INTO `t_dispatchandinsurance` (`idDispatchAndInsurance`, `disandinsPatientCopy`, `disandinsPatientOriginalBill`, `disandinsPatientReceipt`, `disandinsInsurance`, `disandinsMail`, `disandinsAnker`, `fkInsurance`, `fkRefundType`) VALUES
(1, 1, 1, 1, 1, 1, 1, 1, 1),
(2, 1, 2, 1, 2, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_documentbelongtotask`
--

CREATE TABLE `t_documentbelongtotask` (
  `fkDocument` int(11) NOT NULL,
  `idTask` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_drugintolerance`
--

CREATE TABLE `t_drugintolerance` (
  `idDrugIntolerance` smallint(6) NOT NULL,
  `druintName` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_drugintolerance`
--

INSERT INTO `t_drugintolerance` (`idDrugIntolerance`, `druintName`) VALUES
(1, 'Drug'),
(2, 'Serup'),
(3, 'dr');

-- --------------------------------------------------------

--
-- Table structure for table `t_employees`
--

CREATE TABLE `t_employees` (
  `idEmployees` int(4) NOT NULL,
  `empName` varchar(50) NOT NULL,
  `empCity` int(4) NOT NULL,
  `empMainPhone` int(15) NOT NULL,
  `empPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_employees`
--

INSERT INTO `t_employees` (`idEmployees`, `empName`, `empCity`, `empMainPhone`, `empPhoto`) VALUES
(1, 'Alexander', 2, 2147483647, 'https://picsum.photos/50/50?image=834'),
(2, 'Lorik', 18, 2147483647, 'https://picsum.photos/50/50?image=401'),
(3, 'Simon', 7, 2147483647, 'https://picsum.photos/50/50?image=502'),
(4, 'Liam', 11, 2147483647, 'https://picsum.photos/50/50?image=305'),
(5, 'Manuel', 16, 2147483647, ''),
(6, 'Jason', 1, 2147483647, 'https://picsum.photos/50/50?image=18'),
(7, 'Finn', 1, 2147483647, 'https://picsum.photos/50/50?image=173'),
(8, 'Aaron', 12, 2147483647, 'https://picsum.photos/50/50?image=809'),
(9, 'Leo', 4, 2147483647, 'https://picsum.photos/50/50?image=530'),
(10, 'Leo', 15, 2147483647, ''),
(11, 'Ben', 11, 2147483647, 'https://picsum.photos/50/50?image=223'),
(12, 'Andrin', 19, 2147483647, 'https://picsum.photos/50/50?image=521'),
(13, 'Lorenzo', 1, 2147483647, 'https://picsum.photos/50/50?image=937'),
(14, 'Nicolas', 3, 2147483647, 'https://picsum.photos/50/50?image=122'),
(15, 'Adam', 14, 2147483647, ''),
(16, 'Timo', 20, 2147483647, 'https://picsum.photos/50/50?image=798'),
(17, 'Maximilian', 20, 2147483647, 'https://picsum.photos/50/50?image=625'),
(18, 'Julian', 15, 2147483647, 'https://picsum.photos/50/50?image=732'),
(19, 'Nicolas', 13, 2147483647, 'https://picsum.photos/50/50?image=782'),
(20, 'Alessandro', 7, 2147483647, ''),
(21, 'Simon', 13, 2147483647, 'https://picsum.photos/50/50?image=715'),
(22, 'Luca', 19, 2147483647, 'https://picsum.photos/50/50?image=229'),
(23, 'Daniel', 20, 2147483647, 'https://picsum.photos/50/50?image=997'),
(24, 'Timo', 3, 2147483647, 'https://picsum.photos/50/50?image=303'),
(25, 'Dario', 11, 2147483647, ''),
(26, 'Lorik', 14, 2147483647, 'https://picsum.photos/50/50?image=519'),
(27, 'Elias', 8, 2147483647, 'https://picsum.photos/50/50?image=686'),
(28, 'Hugo', 10, 2147483647, 'https://picsum.photos/50/50?image=874'),
(29, 'Livio', 16, 2147483647, 'https://picsum.photos/50/50?image=311'),
(30, 'Nicolas', 4, 2147483647, ''),
(31, 'Livio', 4, 2147483647, 'https://picsum.photos/50/50?image=930'),
(32, 'Noah', 10, 2147483647, 'https://picsum.photos/50/50?image=721'),
(33, 'Fabio', 5, 2147483647, 'https://picsum.photos/50/50?image=812'),
(34, 'Nathan', 4, 2147483647, 'https://picsum.photos/50/50?image=898'),
(35, 'Maximilian', 16, 2147483647, ''),
(36, 'Nicolas', 10, 2147483647, 'https://picsum.photos/50/50?image=55'),
(37, 'Leonardo', 10, 2147483647, 'https://picsum.photos/50/50?image=576'),
(38, 'Jan', 5, 2147483647, 'https://picsum.photos/50/50?image=715'),
(39, 'Max', 20, 2147483647, 'https://picsum.photos/50/50?image=849'),
(40, 'Valentin', 14, 2147483647, ''),
(41, 'Livio', 18, 2147483647, 'https://picsum.photos/50/50?image=101'),
(42, 'Alex', 13, 2147483647, 'https://picsum.photos/50/50?image=955'),
(43, 'Felix', 15, 2147483647, 'https://picsum.photos/50/50?image=475'),
(44, 'Daniel', 6, 2147483647, 'https://picsum.photos/50/50?image=506'),
(45, 'Damian', 4, 2147483647, ''),
(46, 'Fabio', 19, 2147483647, 'https://picsum.photos/50/50?image=106'),
(47, 'Ethan', 13, 2147483647, 'https://picsum.photos/50/50?image=11'),
(48, 'Manuel', 3, 2147483647, 'https://picsum.photos/50/50?image=732'),
(49, 'Louis', 9, 2147483647, 'https://picsum.photos/50/50?image=632'),
(50, 'Noah', 16, 2147483647, ''),
(51, 'Nils', 9, 2147483647, 'https://picsum.photos/50/50?image=964'),
(52, 'Robin', 12, 2147483647, 'https://picsum.photos/50/50?image=922'),
(53, 'Oliver', 14, 2147483647, 'https://picsum.photos/50/50?image=720'),
(54, 'Mateo', 13, 2147483647, 'https://picsum.photos/50/50?image=831'),
(55, 'Levi', 12, 2147483647, ''),
(56, 'Julian', 3, 2147483647, 'https://picsum.photos/50/50?image=995'),
(57, 'Thomas', 2, 2147483647, 'https://picsum.photos/50/50?image=483'),
(58, 'Timo', 4, 1076671014, 'https://picsum.photos/50/50?image=427'),
(59, 'Timo', 6, 2147483647, 'https://picsum.photos/50/50?image=687'),
(60, 'Ben', 15, 2147483647, ''),
(61, 'Paul', 3, 2147483647, 'https://picsum.photos/50/50?image=156'),
(62, 'Kevin', 17, 2147483647, 'https://picsum.photos/50/50?image=714'),
(63, 'Elia', 12, 2147483647, 'https://picsum.photos/50/50?image=106'),
(64, 'Laurin', 14, 2147483647, 'https://picsum.photos/50/50?image=384'),
(65, 'Lio', 11, 2147483647, ''),
(66, 'Emil', 12, 2147483647, 'https://picsum.photos/50/50?image=601'),
(67, 'Lars', 19, 2147483647, 'https://picsum.photos/50/50?image=855'),
(68, 'Marco', 4, 2147483647, 'https://picsum.photos/50/50?image=474'),
(69, 'Dario', 20, 2147483647, 'https://picsum.photos/50/50?image=800'),
(70, 'Kilian', 8, 2147483647, ''),
(71, 'Matteo', 3, 2147483647, 'https://picsum.photos/50/50?image=580'),
(72, 'Jason', 16, 2147483647, 'https://picsum.photos/50/50?image=498'),
(73, 'Jan', 20, 2147483647, 'https://picsum.photos/50/50?image=749'),
(74, 'Theo', 2, 2147483647, 'https://picsum.photos/50/50?image=254'),
(75, 'Marco', 17, 2147483647, ''),
(76, 'Joel', 6, 2147483647, 'https://picsum.photos/50/50?image=18'),
(77, 'Arthur', 8, 2147483647, 'https://picsum.photos/50/50?image=329'),
(78, 'Gian', 10, 2147483647, 'https://picsum.photos/50/50?image=590'),
(79, 'Theo', 9, 2147483647, 'https://picsum.photos/50/50?image=964'),
(80, 'Nolan', 2, 2147483647, ''),
(81, 'Adrian', 4, 2147483647, 'https://picsum.photos/50/50?image=51'),
(82, 'Noah', 14, 2147483647, 'https://picsum.photos/50/50?image=360'),
(83, 'Kilian', 10, 2147483647, 'https://picsum.photos/50/50?image=647'),
(84, 'Linus', 9, 2147483647, 'https://picsum.photos/50/50?image=157'),
(85, 'Ethan', 5, 2147483647, ''),
(86, 'Valentin', 18, 2147483647, 'https://picsum.photos/50/50?image=839'),
(87, 'Tim', 6, 2147483647, 'https://picsum.photos/50/50?image=725'),
(88, 'Mateo', 7, 2147483647, 'https://picsum.photos/50/50?image=109'),
(89, 'Alex', 4, 2147483647, 'https://picsum.photos/50/50?image=368'),
(90, 'Nevio', 2, 2147483647, ''),
(91, 'Noel', 7, 2147483647, 'https://picsum.photos/50/50?image=511'),
(92, 'Felix', 15, 2147483647, 'https://picsum.photos/50/50?image=453'),
(93, 'Lukas', 10, 2147483647, 'https://picsum.photos/50/50?image=731'),
(94, 'Thomas', 10, 2147483647, 'https://picsum.photos/50/50?image=295'),
(95, 'Leo', 12, 2147483647, ''),
(96, 'Diego', 19, 2147483647, 'https://picsum.photos/50/50?image=283'),
(97, 'Maël', 18, 2147483647, 'https://picsum.photos/50/50?image=527'),
(98, 'Kevin', 12, 2147483647, 'https://picsum.photos/50/50?image=787'),
(99, 'Adam', 17, 2147483647, 'https://picsum.photos/50/50?image=353'),
(100, 'Jan', 1, 2147483647, ''),
(101, 'Moritz', 1, 2147483647, 'https://picsum.photos/50/50?image=405'),
(102, 'Luca', 1, 2147483647, 'https://picsum.photos/50/50?image=964'),
(103, 'Luca', 13, 2147483647, 'https://picsum.photos/50/50?image=605'),
(104, 'Loris', 18, 2147483647, 'https://picsum.photos/50/50?image=134'),
(105, 'Matteo', 12, 2147483647, ''),
(106, 'Alexander', 14, 2147483647, 'https://picsum.photos/50/50?image=854'),
(107, 'Nico', 10, 2147483647, 'https://picsum.photos/50/50?image=866'),
(108, 'Lian', 10, 2147483647, 'https://picsum.photos/50/50?image=770'),
(109, 'Lionel', 7, 2147483647, 'https://picsum.photos/50/50?image=252'),
(110, 'David', 15, 2147483647, ''),
(111, 'Arthur', 5, 2147483647, 'https://picsum.photos/50/50?image=948'),
(112, 'Rafael', 3, 2147483647, 'https://picsum.photos/50/50?image=985'),
(113, 'Finn', 17, 2147483647, 'https://picsum.photos/50/50?image=84'),
(114, 'Lionel', 1, 2147483647, 'https://picsum.photos/50/50?image=458'),
(115, 'Luca', 8, 2147483647, ''),
(116, 'Levin', 2, 2147483647, 'https://picsum.photos/50/50?image=41'),
(117, 'Andrin', 13, 2147483647, 'https://picsum.photos/50/50?image=826'),
(118, 'Timo', 12, 2147483647, 'https://picsum.photos/50/50?image=11'),
(119, 'Nino', 19, 2147483647, 'https://picsum.photos/50/50?image=571'),
(120, 'Paul', 19, 2147483647, '');

-- --------------------------------------------------------

--
-- Table structure for table `t_employerbelongtoappointment`
--

CREATE TABLE `t_employerbelongtoappointment` (
  `idAppointment` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_employerbelongtoappointment`
--

INSERT INTO `t_employerbelongtoappointment` (`idAppointment`, `id`) VALUES
(21, 1),
(105, 1),
(367, 1),
(368, 1),
(375, 1),
(376, 1),
(377, 1),
(378, 1),
(379, 1),
(380, 1),
(414, 1),
(415, 1),
(416, 1),
(425, 1),
(426, 1),
(427, 1),
(428, 1),
(429, 1),
(430, 1),
(431, 1),
(369, 2),
(370, 2),
(54, 3),
(371, 3),
(372, 3),
(417, 3),
(418, 3),
(421, 3),
(102, 4),
(373, 4),
(374, 4),
(419, 4),
(420, 4),
(422, 4),
(423, 4),
(424, 4),
(28, 5),
(104, 5),
(31, 6),
(31, 8),
(55, 8),
(106, 8),
(108, 8),
(109, 8),
(110, 8),
(111, 8),
(115, 8),
(118, 8),
(122, 8),
(123, 8),
(128, 8),
(131, 8),
(134, 8),
(136, 8),
(138, 8),
(287, 8),
(288, 8),
(334, 8),
(336, 8),
(345, 8),
(346, 8),
(347, 8),
(348, 8),
(349, 8),
(350, 8),
(351, 8),
(352, 8),
(353, 8),
(357, 8),
(358, 8),
(359, 8),
(360, 8),
(361, 8),
(362, 8),
(363, 8),
(28, 9),
(14, 10),
(99, 10),
(285, 11),
(299, 11),
(302, 11),
(303, 11),
(305, 11),
(308, 11),
(309, 11),
(284, 13),
(31, 14),
(55, 15),
(105, 15),
(114, 15),
(117, 15),
(121, 15),
(124, 15),
(126, 15),
(130, 15),
(133, 15),
(135, 15),
(56, 16),
(32, 17),
(57, 17),
(55, 19),
(98, 19),
(293, 42),
(296, 42),
(297, 42),
(298, 42),
(312, 42),
(313, 42),
(314, 42),
(315, 42),
(317, 42),
(319, 42),
(320, 42),
(321, 42),
(324, 42),
(344, 42),
(141, 43),
(169, 44),
(170, 44),
(171, 44),
(172, 44),
(173, 44),
(175, 44),
(342, 44),
(181, 46),
(274, 67),
(275, 67),
(276, 67),
(277, 67),
(278, 67),
(279, 67),
(286, 77),
(289, 77),
(290, 77),
(112, 81),
(113, 81),
(116, 81),
(119, 81),
(120, 81),
(125, 81),
(127, 81),
(129, 81),
(132, 81),
(137, 81),
(139, 81),
(182, 81),
(183, 81),
(184, 81),
(185, 81),
(186, 81),
(187, 81),
(188, 81),
(189, 81),
(190, 81),
(191, 81),
(192, 81),
(193, 81),
(194, 81),
(195, 81),
(196, 81),
(197, 81),
(198, 81),
(199, 81),
(200, 81),
(201, 81),
(202, 81),
(203, 81),
(204, 81),
(205, 81),
(206, 81),
(207, 81),
(208, 81),
(209, 81),
(210, 81),
(211, 81),
(212, 81),
(213, 81),
(214, 81),
(215, 81),
(216, 81),
(217, 81),
(218, 81),
(219, 81),
(220, 81),
(221, 81),
(222, 81),
(223, 81),
(224, 81),
(225, 81),
(226, 81),
(227, 81),
(228, 81),
(229, 81),
(230, 81),
(231, 81),
(232, 81),
(233, 81),
(234, 81),
(235, 81),
(236, 81),
(237, 81),
(238, 81),
(239, 81),
(240, 81),
(241, 81),
(242, 81),
(243, 81),
(244, 81),
(245, 81),
(246, 81),
(247, 81),
(248, 81),
(249, 81),
(250, 81),
(251, 81),
(252, 81),
(253, 81),
(254, 81),
(255, 81),
(256, 81),
(257, 81),
(258, 81),
(259, 81),
(260, 81),
(261, 81),
(262, 81),
(263, 81),
(264, 81),
(265, 81),
(266, 81),
(267, 81),
(268, 81),
(269, 81),
(270, 81),
(271, 81),
(272, 81),
(273, 81),
(280, 81),
(281, 81),
(159, 89),
(160, 89),
(161, 89),
(162, 89),
(163, 89),
(164, 89),
(165, 89),
(166, 89),
(167, 89),
(168, 89),
(174, 89),
(176, 89),
(107, 99),
(140, 99),
(142, 99),
(143, 99),
(144, 99),
(145, 99),
(146, 99),
(180, 99),
(291, 99),
(292, 99),
(294, 99),
(326, 99),
(329, 99),
(330, 99),
(332, 99),
(338, 99),
(341, 99),
(343, 99),
(354, 99),
(355, 99),
(356, 99),
(177, 108),
(178, 108),
(179, 108),
(147, 111),
(148, 111),
(149, 111),
(150, 111),
(151, 111),
(152, 111),
(153, 111),
(154, 111),
(155, 111),
(156, 111),
(157, 111),
(158, 111),
(282, 111),
(283, 111),
(295, 117);

-- --------------------------------------------------------

--
-- Table structure for table `t_employers`
--

CREATE TABLE `t_employers` (
  `idEmployers` int(6) NOT NULL,
  `empName` varchar(255) NOT NULL,
  `empStreet` varchar(255) NOT NULL,
  `empStreetNumber` varchar(255) NOT NULL,
  `empAddressComplement` varchar(255) NOT NULL,
  `empZip` int(5) NOT NULL,
  `empCity` varchar(255) NOT NULL,
  `empCountry` varchar(255) NOT NULL,
  `empPhone` varchar(255) NOT NULL,
  `empCallingCode` varchar(255) NOT NULL,
  `empContactPerson` int(11) NOT NULL,
  `empPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_establishment`
--

CREATE TABLE `t_establishment` (
  `idEstablishment` int(11) NOT NULL,
  `estName` varchar(255) NOT NULL,
  `estImageLink` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_establishment`
--

INSERT INTO `t_establishment` (`idEstablishment`, `estName`, `estImageLink`) VALUES
(1, 'Cabinet Medical du Bristol', 'img/aside-logo-1.png'),
(2, 'Cabinet medical de Villeneuve', 'img/aside-logo-2.png');

-- --------------------------------------------------------

--
-- Table structure for table `t_establishmentbelongtoconfig`
--

CREATE TABLE `t_establishmentbelongtoconfig` (
  `fkEstablishment` int(11) NOT NULL,
  `fkconfig` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_establishmentbelongtoconfig`
--

INSERT INTO `t_establishmentbelongtoconfig` (`fkEstablishment`, `fkconfig`) VALUES
(1, 1),
(2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_familyrelationship`
--

CREATE TABLE `t_familyrelationship` (
  `idFamilyRelationship` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_hasstep`
--

CREATE TABLE `t_hasstep` (
  `idTask` int(11) NOT NULL,
  `idStep` int(11) NOT NULL,
  `stepOrder` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_infotype`
--

CREATE TABLE `t_infotype` (
  `idInfoType` int(11) NOT NULL,
  `infName` varchar(255) NOT NULL,
  `infImageLink` varchar(255) NOT NULL,
  `infTable` varchar(255) NOT NULL,
  `infDisplayWith` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_infotype`
--

INSERT INTO `t_infotype` (`idInfoType`, `infName`, `infImageLink`, `infTable`, `infDisplayWith`) VALUES
(1, 'patient', '#logo-annuaire', 't_patients.idPatients', 'directory.php?pat='),
(2, 'billing', '#logo-facturation', 't_bill.idBill', 'billing.php?bil='),
(3, 'medical', '#logo-consultation', 't_consultation.idConsultation', 'consultation.php?con='),
(4, 'agenda', '#logo-calendar', 't_appointment.idAppointment', 'agenda.php?app=');

-- --------------------------------------------------------

--
-- Table structure for table `t_insurancebelongtoappointment`
--

CREATE TABLE `t_insurancebelongtoappointment` (
  `idAppointment` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_insurancebelongtoappointment`
--

INSERT INTO `t_insurancebelongtoappointment` (`idAppointment`, `id`) VALUES
(33, 5),
(56, 16),
(57, 18);

-- --------------------------------------------------------

--
-- Table structure for table `t_insurances`
--

CREATE TABLE `t_insurances` (
  `idInsurances` int(4) NOT NULL,
  `insName` varchar(50) NOT NULL,
  `insCity` int(4) NOT NULL,
  `insMainPhone` int(15) NOT NULL,
  `insPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_insurances`
--

INSERT INTO `t_insurances` (`idInsurances`, `insName`, `insCity`, `insMainPhone`, `insPhoto`) VALUES
(1, 'AXA', 10, 2147483647, ''),
(2, 'CSS', 12, 2147483647, ''),
(3, 'Groupe Mutuel Philos', 2, 2147483647, ''),
(4, 'General Lee', 4, 2147483647, ''),
(5, 'Assura', 5, 2147483647, ''),
(6, 'SUVA', 19, 2147483647, ''),
(7, 'Helsana', 11, 2147483647, ''),
(8, 'Concordia', 8, 2147483647, ''),
(9, 'Sanitas', 12, 2147483647, ''),
(10, 'KPT/CPT Holding', 16, 2147483647, ''),
(11, 'Wincare', 13, 2147483647, ''),
(12, 'Atupri', 2, 2147483647, ''),
(13, 'ÖKK', 2, 2147483647, ''),
(14, 'EGK-Gesundheitskasse', 12, 2147483647, ''),
(15, 'Sympany', 15, 2147483647, ''),
(16, 'Sansan Versicherungen', 1, 2147483647, ''),
(17, 'Agrisano', 7, 2147483647, ''),
(18, 'Avanex', 1, 2147483647, ''),
(19, 'Carena Schweiz', 10, 2147483647, ''),
(20, 'Fondation AMB', 20, 2147483647, '');

-- --------------------------------------------------------

--
-- Table structure for table `t_invoice`
--

CREATE TABLE `t_invoice` (
  `idInvoice` int(11) NOT NULL,
  `invDate` date NOT NULL,
  `invExpiration` date NOT NULL,
  `invStartPeriod` date NOT NULL,
  `invEndPeriod` date NOT NULL,
  `invDescription` varchar(255) CHARACTER SET latin1 NOT NULL,
  `invAmount` decimal(6,2) NOT NULL,
  `invPaymentPlan` int(2) NOT NULL,
  `invDiscount` decimal(2,2) NOT NULL,
  `invDiscountUnit` varchar(255) CHARACTER SET latin1 NOT NULL,
  `fkDispatchAndInsurance` int(11) NOT NULL,
  `fkMedicalEstablishment` int(11) NOT NULL,
  `fkMedicalCase` int(11) DEFAULT NULL,
  `fkInvoiceStatus` int(11) NOT NULL,
  `fkPatient` int(11) NOT NULL,
  `fkMedicalActor` int(11) NOT NULL,
  `fkBankAccount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_invoice`
--

INSERT INTO `t_invoice` (`idInvoice`, `invDate`, `invExpiration`, `invStartPeriod`, `invEndPeriod`, `invDescription`, `invAmount`, `invPaymentPlan`, `invDiscount`, `invDiscountUnit`, `fkDispatchAndInsurance`, `fkMedicalEstablishment`, `fkMedicalCase`, `fkInvoiceStatus`, `fkPatient`, `fkMedicalActor`, `fkBankAccount`) VALUES
(1, '2019-01-28', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '446.04', 1, '0.00', '%', 1, 7, NULL, 3, 5, 1, 2),
(2, '2019-01-18', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '85.35', 1, '0.00', '%', 1, 7, NULL, 3, 23, 1, 2),
(3, '2019-01-19', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '85.13', 1, '0.00', '%', 1, 7, NULL, 2, 23, 1, 2),
(4, '2019-01-29', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '166.12', 1, '0.00', '%', 1, 7, NULL, 1, 22, 1, 2),
(5, '2019-01-24', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '571.74', 1, '0.00', '%', 1, 7, NULL, 2, 18, 1, 2),
(6, '2019-01-18', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '356.84', 1, '0.00', '%', 1, 7, NULL, 3, 24, 1, 2),
(7, '2019-01-19', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '65.51', 1, '0.00', '%', 1, 7, NULL, 3, 18, 1, 2),
(8, '2019-01-23', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '253.52', 1, '0.00', '%', 1, 7, NULL, 1, 16, 1, 2),
(9, '2019-01-30', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '67.60', 1, '0.00', '%', 1, 7, NULL, 1, 3, 1, 2),
(10, '2019-01-19', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '573.95', 1, '0.00', '%', 1, 7, NULL, 2, 17, 1, 2),
(11, '2019-01-18', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '663.49', 1, '0.00', '%', 1, 7, NULL, 1, 24, 1, 2),
(12, '2019-01-18', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '592.10', 1, '0.00', '%', 1, 7, NULL, 3, 23, 1, 2),
(13, '2019-01-21', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '966.54', 1, '0.00', '%', 1, 7, NULL, 1, 18, 1, 2),
(14, '2019-01-21', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '52.95', 1, '0.00', '%', 1, 7, NULL, 3, 21, 1, 2),
(15, '2019-01-25', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '361.63', 1, '0.00', '%', 1, 7, NULL, 3, 1, 1, 2),
(16, '2019-01-17', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '645.78', 1, '0.00', '%', 1, 7, NULL, 3, 20, 1, 2),
(17, '2019-01-24', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '140.57', 1, '0.00', '%', 1, 7, NULL, 1, 20, 1, 2),
(18, '2019-01-25', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '761.98', 1, '0.00', '%', 1, 7, NULL, 1, 16, 1, 2),
(19, '2019-01-22', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '384.75', 1, '0.00', '%', 1, 7, NULL, 2, 22, 1, 2),
(20, '2019-01-20', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '634.31', 1, '0.00', '%', 1, 7, NULL, 2, 10, 1, 2),
(21, '2019-01-18', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '13.82', 1, '0.00', '%', 1, 7, NULL, 3, 10, 1, 2),
(22, '2019-01-30', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '162.66', 1, '0.00', '%', 1, 7, NULL, 2, 22, 1, 2),
(23, '2019-01-20', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '768.36', 1, '0.00', '%', 1, 7, NULL, 1, 5, 1, 2),
(24, '2019-01-25', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '350.37', 1, '0.00', '%', 1, 7, NULL, 1, 9, 1, 2),
(25, '2019-01-18', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '443.26', 1, '0.00', '%', 1, 7, NULL, 2, 5, 1, 2),
(26, '2019-01-31', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '161.70', 1, '0.00', '%', 1, 7, NULL, 1, 24, 1, 2),
(27, '2019-01-22', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '475.25', 1, '0.00', '%', 1, 7, NULL, 3, 4, 1, 2),
(28, '2019-01-17', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '887.63', 1, '0.00', '%', 1, 7, NULL, 2, 23, 1, 2),
(29, '2019-01-20', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 1', '8.97', 1, '0.00', '%', 1, 7, NULL, 2, 4, 1, 2),
(30, '2019-01-16', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 2', '378.42', 1, '0.00', '%', 1, 7, NULL, 3, 4, 1, 2),
(31, '2019-01-23', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 3', '861.72', 1, '0.00', '%', 1, 7, NULL, 2, 7, 1, 2),
(32, '2019-01-20', '2019-02-02', '2018-12-01', '2019-01-01', 'Facture 4', '169.89', 1, '0.00', '%', 1, 7, NULL, 2, 24, 1, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_invoicestatus`
--

CREATE TABLE `t_invoicestatus` (
  `idInvoiceStatus` int(11) NOT NULL,
  `invstaName` varchar(255) CHARACTER SET latin1 NOT NULL,
  `invstaCode` varchar(255) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_invoicestatus`
--

INSERT INTO `t_invoicestatus` (`idInvoiceStatus`, `invstaName`, `invstaCode`) VALUES
(1, 'Payé', 'paid'),
(2, 'Non Payée', 'unpaid'),
(3, 'Partiellement payé', 'partially_paid');

-- --------------------------------------------------------

--
-- Table structure for table `t_licenseestablishment`
--

CREATE TABLE `t_licenseestablishment` (
  `idLicenseEstablishment` int(11) NOT NULL,
  `fkMedicalEstablishment` int(11) NOT NULL,
  `licestLicenseNumber` varchar(100) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_licenseestablishment`
--

INSERT INTO `t_licenseestablishment` (`idLicenseEstablishment`, `fkMedicalEstablishment`, `licestLicenseNumber`) VALUES
(1, 106, 'dgsg'),
(2, 107, 'gsgd'),
(3, 108, 'sdgsdgh'),
(4, 109, 'sdgsgds'),
(5, 208, 'TYI');

-- --------------------------------------------------------

--
-- Table structure for table `t_log`
--

CREATE TABLE `t_log` (
  `idLog` int(11) NOT NULL,
  `logText` varchar(255) NOT NULL,
  `logDate` date NOT NULL,
  `logHour` time NOT NULL,
  `fkUser` int(11) NOT NULL,
  `fkInfoType` int(11) NOT NULL,
  `logTableToSearchIn` varchar(255) DEFAULT NULL,
  `logPropertyToSearchIn` varchar(255) DEFAULT NULL,
  `logIdToSearch` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_log`
--

INSERT INTO `t_log` (`idLog`, `logText`, `logDate`, `logHour`, `fkUser`, `fkInfoType`, `logTableToSearchIn`, `logPropertyToSearchIn`, `logIdToSearch`) VALUES
(1, ' Ã  creer un rendez vous', '2018-12-11', '09:39:06', 2, 1, NULL, NULL, NULL),
(2, ' Ã  consulter la session PHP', '2018-12-11', '09:40:53', 2, 1, NULL, NULL, NULL),
(3, ' Ã  creer un rendez vous', '2018-12-11', '09:49:18', 2, 4, NULL, NULL, NULL),
(4, ' s\'est connecté', '2018-12-11', '09:51:24', 2, 4, NULL, NULL, NULL),
(5, ' s\'est connecté', '2018-12-11', '10:29:52', 1, 4, NULL, NULL, NULL),
(6, ' Ã  creer un rendez vous', '2018-12-11', '10:30:05', 1, 4, NULL, NULL, NULL),
(7, ' Ã  creer un rendez vous', '2018-12-11', '10:30:32', 1, 4, NULL, NULL, NULL),
(8, ' s\'est connecté', '2018-12-11', '10:30:46', 3, 4, NULL, NULL, NULL),
(9, ' Ã  creer un rendez vous', '2018-12-11', '10:31:00', 3, 4, NULL, NULL, NULL),
(10, ' Ã  creer un rendez vous', '2018-12-11', '10:31:01', 3, 4, NULL, NULL, NULL),
(11, ' s\'est connecté', '2018-12-11', '10:52:21', 2, 4, NULL, NULL, NULL),
(12, ' Ã  creer un rendez vous', '2018-12-11', '10:53:28', 2, 4, NULL, NULL, NULL),
(13, ' Ã  creer un rendez vous', '2018-12-11', '10:53:32', 2, 4, NULL, NULL, NULL),
(14, ' Ã  creer un rendez vous', '2018-12-11', '10:57:37', 2, 4, NULL, NULL, NULL),
(15, ' Ã  creer un rendez vous', '2018-12-11', '10:58:09', 2, 4, NULL, NULL, NULL),
(16, ' Ã  creer un rendez vous', '2018-12-11', '13:59:54', 2, 4, NULL, NULL, NULL),
(17, ' Ã  consulter la session PHP', '2018-12-11', '16:24:58', 2, 1, NULL, NULL, NULL),
(18, ' s\'est connecté', '2018-12-11', '16:28:43', 3, 4, NULL, NULL, NULL),
(19, ' s\'est connecté', '2018-12-11', '16:28:44', 3, 4, NULL, NULL, NULL),
(20, ' s\'est connecté', '2018-12-11', '16:28:45', 3, 4, NULL, NULL, NULL),
(21, ' s\'est connecté', '2018-12-11', '16:28:45', 3, 4, NULL, NULL, NULL),
(22, ' s\'est connecté', '2018-12-11', '16:28:45', 3, 4, NULL, NULL, NULL),
(23, ' s\'est connecté', '2018-12-11', '16:28:45', 3, 4, NULL, NULL, NULL),
(24, ' s\'est connecté', '2018-12-11', '16:28:45', 3, 4, NULL, NULL, NULL),
(25, ' s\'est connecté', '2018-12-12', '08:08:10', 2, 4, NULL, NULL, NULL),
(26, ' Ã  consulter la session PHP', '2018-12-12', '08:42:44', 2, 1, NULL, NULL, NULL),
(27, ' Ã  consulter la session PHP', '2018-12-12', '08:43:29', 2, 1, NULL, NULL, NULL),
(28, ' Ã  consulter la session PHP', '2018-12-12', '08:44:58', 2, 1, NULL, NULL, NULL),
(29, ' Ã  consulter la session PHP', '2018-12-12', '08:46:03', 2, 1, NULL, NULL, NULL),
(30, ' s\'est connecté', '2018-12-12', '09:00:58', 3, 4, NULL, NULL, NULL),
(31, ' s\'est connecté', '2018-12-12', '09:18:59', 2, 4, NULL, NULL, NULL),
(32, ' s\'est connecté', '2018-12-12', '10:43:56', 3, 4, NULL, NULL, NULL),
(33, ' s\'est connecté', '2018-12-12', '10:46:39', 2, 4, NULL, NULL, NULL),
(34, ' s\'est connecté', '2018-12-13', '08:11:35', 2, 4, NULL, NULL, NULL),
(35, ' à creer un rendez vous', '2018-12-13', '12:45:39', 2, 4, NULL, NULL, NULL),
(36, ' s\'est connecté', '2018-12-13', '16:13:14', 2, 4, NULL, NULL, NULL),
(37, ' s\'est connecté', '2018-12-13', '17:45:35', 2, 4, NULL, NULL, NULL),
(38, ' s\'est connecté', '2018-12-13', '17:47:43', 1, 4, NULL, NULL, NULL),
(39, ' s\'est connecté', '2018-12-13', '17:48:00', 2, 4, NULL, NULL, NULL),
(40, ' s\'est connecté', '2018-12-14', '09:49:40', 2, 4, NULL, NULL, NULL),
(41, ' s\'est connecté', '2018-12-14', '12:34:49', 2, 4, 'null', 'null', 'null'),
(42, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=407\'>407</a>', '2018-12-14', '12:34:55', 2, 4, 't_appointment', 'idAppointment', '407'),
(43, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=408\'>408</a>', '2018-12-14', '12:36:34', 2, 4, 't_appointment', 'idAppointment', '408'),
(44, ' à consulter la session PHP', '2018-12-14', '12:36:53', 2, 1, 'null', 'null', 'null'),
(45, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=409\'>Consultation</a>', '2018-12-14', '12:55:32', 2, 4, 't_appointment', 'idAppointment', '409'),
(46, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=410\'>Consultation</a>', '2018-12-14', '12:55:32', 2, 4, 't_appointment', 'idAppointment', '410'),
(47, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=411\'>Consultation</a>', '2018-12-14', '12:55:35', 2, 4, 't_appointment', 'idAppointment', '411'),
(48, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=412\'>Consultation</a>', '2018-12-14', '12:55:36', 2, 4, 't_appointment', 'idAppointment', '412'),
(49, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=413\'>Consultation</a>', '2018-12-14', '12:55:39', 2, 4, 't_appointment', 'idAppointment', '413'),
(50, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=414\'>Consultation</a>', '2018-12-14', '12:56:52', 2, 4, 't_appointment', 'idAppointment', '414'),
(51, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=415\'>Consultation</a>', '2018-12-14', '13:34:09', 2, 4, 't_appointment', 'idAppointment', '415'),
(52, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=416\'>Consultation</a>', '2018-12-14', '13:35:29', 2, 4, 't_appointment', 'idAppointment', '416'),
(53, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=417\'>Consultation</a>', '2018-12-14', '13:36:52', 2, 4, 't_appointment', 'idAppointment', '417'),
(54, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=418\'>Consultation</a>', '2018-12-14', '13:36:53', 2, 4, 't_appointment', 'idAppointment', '418'),
(55, ' s\'est connecté', '2018-12-14', '14:03:40', 3, 4, 'null', 'null', 'null'),
(56, ' à creer un le rendez-vous <a href=\'agenda.php?eventId=419\'>Consultation</a>', '2018-12-14', '14:03:44', 3, 4, 't_appointment', 'idAppointment', '419'),
(57, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=420\'>Consultation</a> dans le calendrier de <a href=\'agenda.php\'> G.Tardieu</a>', '2018-12-14', '14:06:40', 3, 4, 't_appointment', 'idAppointment', '420'),
(58, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=421\'>Consultation</a> dans le calendrier de <a href=\'agenda.php\'>G. Tardieu</a>', '2018-12-14', '14:28:50', 3, 4, 't_appointment', 'idAppointment', '421'),
(59, ' s\'est connecté', '2018-12-14', '14:29:13', 2, 4, 'null', 'null', 'null'),
(60, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=422\'>Consultation</a> dans le calendrier de <a href=\'agenda.php\'>G. Krieger</a>', '2018-12-14', '14:29:23', 2, 4, 't_appointment', 'idAppointment', '422'),
(61, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=423\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=4\'>G. Krieger</a>', '2018-12-14', '14:34:40', 2, 4, 't_appointment', 'idAppointment', '423'),
(62, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=424&?calendarId=4\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=4\'>G. Krieger</a>', '2018-12-14', '14:43:50', 2, 4, 't_appointment', 'idAppointment', '424'),
(63, ' s\'est connecté', '2018-12-21', '08:23:18', 2, 4, 'null', 'null', 'null'),
(64, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=425\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2018-12-21', '08:25:12', 2, 4, 't_appointment', 'idAppointment', '425'),
(65, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=426\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2018-12-21', '08:25:16', 2, 4, 't_appointment', 'idAppointment', '426'),
(66, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=427\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2018-12-21', '08:25:25', 2, 4, 't_appointment', 'idAppointment', '427'),
(67, ' s\'est connecté', '2018-12-21', '10:54:09', 2, 4, 'null', 'null', 'null'),
(68, ' s\'est connecté', '2018-12-27', '02:14:17', 2, 4, 'null', 'null', 'null'),
(69, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=428\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2018-12-27', '02:15:11', 2, 4, 't_appointment', 'idAppointment', '428'),
(70, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=429\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2018-12-27', '02:15:17', 2, 4, 't_appointment', 'idAppointment', '429'),
(71, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=430\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2018-12-27', '02:15:22', 2, 4, 't_appointment', 'idAppointment', '430'),
(72, ' s\'est connecté', '2018-12-28', '09:58:40', 2, 4, 'null', 'null', 'null'),
(73, ' s\'est connecté', '2019-01-02', '23:13:42', 2, 4, 'null', 'null', 'null'),
(74, ' s\'est connecté', '2019-01-06', '04:17:03', 2, 4, 'null', 'null', 'null'),
(75, ' à enregistré le rendez-vous <a href=\'agenda.php?eventId=431\'>Consultation</a> dans le calendrier de <a href=\'agenda.php?calendarId=1\'>A. Fasano</a>', '2019-01-08', '13:00:11', 2, 4, 't_appointment', 'idAppointment', '431'),
(76, ' s\'est connecté', '2019-01-23', '11:42:09', 2, 4, 'null', 'null', 'null'),
(77, ' s\'est connecté', '2019-01-24', '06:13:27', 2, 4, 'null', 'null', 'null'),
(78, ' s\'est connecté', '2019-01-24', '06:18:32', 2, 4, 'null', 'null', 'null'),
(79, ' s\'est connecté', '2019-01-24', '06:18:53', 2, 4, 'null', 'null', 'null'),
(80, ' s\'est connecté', '2019-01-24', '06:20:47', 2, 4, 'null', 'null', 'null'),
(81, ' s\'est connecté', '2019-01-24', '06:25:11', 2, 4, 'null', 'null', 'null'),
(82, ' s\'est connecté', '2019-01-24', '07:14:38', 2, 4, 'null', 'null', 'null'),
(83, ' s\'est connecté', '2019-01-24', '09:28:42', 2, 4, 'null', 'null', 'null'),
(84, ' s\'est connecté', '2019-01-24', '09:37:34', 2, 4, 'null', 'null', 'null'),
(85, ' s\'est connecté', '2019-01-24', '09:39:21', 2, 4, 'null', 'null', 'null'),
(86, ' s\'est connecté', '2019-01-24', '09:44:46', 2, 4, 'null', 'null', 'null'),
(87, ' s\'est connecté', '2019-01-24', '09:51:01', 2, 4, 'null', 'null', 'null'),
(88, ' s\'est connecté', '2019-01-24', '09:57:12', 2, 4, 'null', 'null', 'null'),
(89, ' s\'est connecté', '2019-01-25', '23:23:20', 2, 4, 'null', 'null', 'null'),
(90, ' s\'est connecté', '2019-01-26', '01:29:00', 2, 4, 'null', 'null', 'null'),
(91, ' s\'est connecté', '2019-01-26', '04:24:38', 2, 4, 'null', 'null', 'null'),
(92, ' s\'est connecté', '2019-01-26', '04:46:39', 2, 4, 'null', 'null', 'null'),
(93, ' s\'est connecté', '2019-01-26', '05:02:46', 2, 4, 'null', 'null', 'null'),
(94, ' s\'est connecté', '2019-01-26', '05:36:29', 2, 4, 'null', 'null', 'null'),
(95, ' s\'est connecté', '2019-01-26', '06:21:02', 2, 4, 'null', 'null', 'null'),
(96, ' s\'est connecté', '2019-01-26', '06:47:38', 2, 4, 'null', 'null', 'null'),
(97, ' s\'est connecté', '2019-01-26', '10:32:33', 2, 4, 'null', 'null', 'null'),
(98, ' s\'est connecté', '2019-01-27', '14:14:34', 2, 4, 'null', 'null', 'null'),
(99, ' s\'est connecté', '2019-01-27', '17:05:29', 2, 4, 'null', 'null', 'null'),
(100, ' s\'est connecté', '2019-01-27', '17:05:30', 2, 4, 'null', 'null', 'null'),
(101, ' s\'est connecté', '2019-01-29', '06:38:37', 1, 4, 'null', 'null', 'null'),
(102, ' s\'est connecté', '2019-02-05', '12:34:21', 2, 4, 'null', 'null', 'null'),
(103, ' s\'est connecté', '2019-02-11', '10:22:11', 2, 4, 'null', 'null', 'null');

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactor`
--

CREATE TABLE `t_medicalactor` (
  `idMedicalActor` int(11) NOT NULL,
  `medactName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `medactLastname` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactGender` varchar(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `medactTitle` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactMainPhone` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactMainFax` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `medactMainMail` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactPersonalPhone` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `medactPersonalFax` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `medactPersonalMail` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `medactAddress` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactZipcode` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactCity` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactCountry` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medactImageLink` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `fkMedicalActorTitle` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalactor`
--

INSERT INTO `t_medicalactor` (`idMedicalActor`, `medactName`, `medactLastname`, `medactGender`, `medactTitle`, `medactMainPhone`, `medactMainFax`, `medactMainMail`, `medactPersonalPhone`, `medactPersonalFax`, `medactPersonalMail`, `medactAddress`, `medactZipcode`, `medactCity`, `medactCountry`, `medactImageLink`, `fkMedicalActorTitle`) VALUES
(1, 'Anthony', 'Fasano', '', 'Docteur', '0799999999', '', 'adresse@mail.com', '', '', '', 'Rue de l\'adresse 00', '666', 'UneVille', 'UnPays', '1.png', 1),
(2, 'Gregory', 'Krieger', '', 'Professeur', '0799889999', '', 'adresse@mail.com', '', '', '', 'Rue de l\'adresse 04', '1666', 'UneVilleMontreux', 'UnPaysSuisse', '2.png', 1),
(8, 'Lorem', 'Ipsum', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, '8.png', 4),
(9, 'Lorem', 'Ipsum', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, '9.png', 4),
(10, 'Test', '1', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, NULL, 4),
(11, 'Anshuman', 'Pandey', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, NULL, 5),
(12, 'A', 'P', 'M', NULL, '1231231234', '2342342345', 'a@v.b', '4564564567', '5675675678', 'f@r.c', NULL, NULL, NULL, NULL, '12.png', 4),
(13, 'f', 'g', 'M', NULL, '4564564567', '4563453456', 'g@f.v', '', '', '', NULL, NULL, NULL, NULL, '13.png', 6),
(14, '', 'sdg', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, NULL, NULL),
(15, '', 'Krieger', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, NULL, NULL),
(16, '', 'fsdf', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, NULL, NULL),
(17, '', 'James', 'M', NULL, '', '', '', '', '', '', NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactorbelongtoappointment`
--

CREATE TABLE `t_medicalactorbelongtoappointment` (
  `fkMedicalActor` int(11) NOT NULL,
  `fkAppointment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalactorbelongtoappointment`
--

INSERT INTO `t_medicalactorbelongtoappointment` (`fkMedicalActor`, `fkAppointment`) VALUES
(1, 438),
(1, 439),
(1, 440),
(1, 441),
(1, 448),
(12, 449);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactorhaslinkwithpatient`
--

CREATE TABLE `t_medicalactorhaslinkwithpatient` (
  `idxMedicalActor` int(11) NOT NULL,
  `idxPatient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactorhasspecialization`
--

CREATE TABLE `t_medicalactorhasspecialization` (
  `fkMedicalActor` int(11) DEFAULT NULL,
  `fkMedicalActorSpecialization` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalactorhasspecialization`
--

INSERT INTO `t_medicalactorhasspecialization` (`fkMedicalActor`, `fkMedicalActorSpecialization`) VALUES
(8, 1),
(9, 1),
(10, 1),
(11, 2),
(12, 3),
(13, 4);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactorhastitle`
--

CREATE TABLE `t_medicalactorhastitle` (
  `fkMedicalActor` int(11) NOT NULL,
  `fkMedicalActorTitle` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactorspecialization`
--

CREATE TABLE `t_medicalactorspecialization` (
  `idMedicalActorSpecialization` int(11) NOT NULL,
  `speName` varchar(100) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalactorspecialization`
--

INSERT INTO `t_medicalactorspecialization` (`idMedicalActorSpecialization`, `speName`) VALUES
(1, 'Cataloge'),
(2, 'test'),
(3, 'test1'),
(4, 'test123');

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactortitle`
--

CREATE TABLE `t_medicalactortitle` (
  `idMedicalActorTitle` int(11) NOT NULL,
  `medacttitName` varchar(100) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalactortitle`
--

INSERT INTO `t_medicalactortitle` (`idMedicalActorTitle`, `medacttitName`) VALUES
(1, 'Value test 01'),
(2, 'Value test 02'),
(3, 'Value test 03'),
(4, 'Doctor'),
(5, 'Anshuman'),
(6, 'doctorate');

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalactorworksinmedicalestablishment`
--

CREATE TABLE `t_medicalactorworksinmedicalestablishment` (
  `fkMedicalActor` int(11) NOT NULL,
  `fkMedicalEstablishment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalactorworksinmedicalestablishment`
--

INSERT INTO `t_medicalactorworksinmedicalestablishment` (`fkMedicalActor`, `fkMedicalEstablishment`) VALUES
(1, 113),
(1, 114),
(1, 115),
(1, 116),
(1, 117),
(1, 118),
(1, 119),
(1, 120),
(2, 120),
(1, 136),
(1, 174),
(1, 175),
(2, 175),
(1, 193),
(2, 193),
(1, 207),
(2, 207),
(1, 208),
(2, 208),
(1, 209),
(1, 210),
(1, 214),
(1, 215),
(2, 215),
(1, 216),
(2, 216),
(8, 44),
(8, 108),
(9, 108),
(10, 108),
(1, 218),
(11, 19),
(11, 1),
(12, 59),
(12, 215),
(13, 215),
(13, 11),
(14, 215),
(15, 36),
(11, 219),
(1, 219),
(1, 220),
(11, 220);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalestablishment`
--

CREATE TABLE `t_medicalestablishment` (
  `idMedicalEstablishment` int(11) NOT NULL,
  `medestName` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `medestMainPhone` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medestMainMail` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medestMainFax` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medestEmergencyPhone` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `medestEmergencyFax` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `medestEmergencyMail` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `idxMedicalEstablishmentType` int(11) DEFAULT NULL,
  `medestProfilePic` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `medestCanSendMail` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `t_medicalestablishment`
--

INSERT INTO `t_medicalestablishment` (`idMedicalEstablishment`, `medestName`, `medestMainPhone`, `medestMainMail`, `medestMainFax`, `medestEmergencyPhone`, `medestEmergencyFax`, `medestEmergencyMail`, `idxMedicalEstablishmentType`, `medestProfilePic`, `medestCanSendMail`) VALUES
(1, 'La Prairie1', '+376776184395', 'clinique_La Prairie1@test.com', '+495363261593', '', '', '', 1, NULL, 0),
(2, 'La Prairie2', '+359453843315', 'clinique_La Prairie2@test.com', '+897856000853', '', '', '', 1, NULL, 0),
(3, 'La Prairie3', '+928338436662', 'clinique_La Prairie3@test.com', '+085313074915', '', '', '', 1, NULL, 0),
(4, 'La Prairie4', '+365120721313', 'clinique_La Prairie4@test.com', '+028682113961', '', '', '', 1, NULL, 0),
(5, 'La Prairie5', '+413412941457', 'clinique_La Prairie5@test.com', '+589138186941', '', '', '', 1, NULL, 0),
(6, 'La Prairie6', '+941005324855', 'clinique_La Prairie6@test.com', '+656568702892', '', '', '', 1, NULL, 0),
(7, 'Aquamed1', '+478231858518', 'clinique_Aquamed1@test.com', '+348904934039', '', '', '', 1, NULL, 0),
(8, 'Aquamed2', '+223402664816', 'clinique_Aquamed2@test.com', '+996276915682', '', '', '', 1, NULL, 0),
(9, 'Aquamed3', '+182483157971', 'clinique_Aquamed3@test.com', '+083665009726', '', '', '', 1, NULL, 0),
(10, 'Aquamed4', '+801291534682', 'clinique_Aquamed4@test.com', '+853168841541', '', '', '', 1, NULL, 0),
(11, 'Aquamed5', '+216714930225', 'clinique_Aquamed5@test.com', '+409041385196', '', '', '', 1, NULL, 0),
(12, 'Aquamed6', '+004607089618', 'clinique_Aquamed6@test.com', '+657749159559', '', '', '', 1, NULL, 0),
(13, 'Providence1', '+587596833625', 'clinique_Providence1@test.com', '+505246376910', '', '', '', 1, NULL, 0),
(14, 'Providence2', '+778826784033', 'clinique_Providence2@test.com', '+635962423078', '', '', '', 1, NULL, 0),
(15, 'Providence3', '+333968145750', 'clinique_Providence3@test.com', '+508290084337', '', '', '', 1, NULL, 0),
(16, 'Providence4', '+406389065536', 'clinique_Providence4@test.com', '+087887268201', '', '', '', 1, NULL, 0),
(17, 'Providence5', '+339734991462', 'clinique_Providence5@test.com', '+587506060116', '', '', '', 1, NULL, 0),
(18, 'Providence6', '+805046406985', 'clinique_Providence6@test.com', '+879458962613', '', '', '', 1, NULL, 0),
(19, 'Clinique Suisse Montreux1', '+092694737785', 'clinique_Clinique Suisse Montreux1@test.com', '+107290809606', '', '', '', 1, NULL, 0),
(20, 'Clinique Suisse Montreux2', '+440763430469', 'clinique_Clinique Suisse Montreux2@test.com', '+218974368422', '', '', '', 1, NULL, 0),
(21, 'Clinique Suisse Montreux3', '+043507441879', 'clinique_Clinique Suisse Montreux3@test.com', '+555496226560', '', '', '', 1, NULL, 0),
(22, 'Clinique Suisse Montreux4', '+855865098121', 'clinique_Clinique Suisse Montreux4@test.com', '+115794152678', '', '', '', 1, NULL, 0),
(23, 'Clinique Suisse Montreux5', '+847500149998', 'clinique_Clinique Suisse Montreux5@test.com', '+729255474327', '', '', '', 1, NULL, 0),
(24, 'Clinique Suisse Montreux6', '+384851179354', 'clinique_Clinique Suisse Montreux6@test.com', '+604452421616', '', '', '', 1, NULL, 0),
(25, 'CIC Riviera', '+846109458660', 'clinique_CIC Riviera@test.com', '+741816751791', '', '', '', 1, NULL, 0),
(26, 'CIC Chablais', '+866287134403', 'clinique_CIC Chablais@test.com', '+751688322012', '', '', '', 1, NULL, 0),
(27, 'ASMAV', '+729063240805', 'clinique_ASMAV@test.com', '+537342870331', '', '', '', 1, NULL, 0),
(28, 'Clinique Cecil', '+722382150429', 'clinique_Clinique Cecil@test.com', '+475262980646', '', '', '', 1, NULL, 0),
(29, 'Fondation de nant', '+659247674943', 'clinique_Fondation de nant@test.com', '+299961057222', '', '', '', 1, NULL, 0),
(30, 'Pharmacie 24', '+027388637942', 'clinique_Pharmacie 24@test.com', '+632447826541', '', '', '', 2, NULL, 0),
(31, 'Amavita Acacias', '+802883814026', 'clinique_Amavita Acacias@test.com', '+463599099435', '', '', '', 2, NULL, 0),
(32, 'Amavita Cardinaux', '+718534988426', 'clinique_Amavita Cardinaux@test.com', '+808101418435', '', '', '', 2, NULL, 0),
(33, 'Amavita Jura', '+045362851654', 'clinique_Amavita Jura@test.com', '+220372315264', '', '', '', 2, NULL, 0),
(34, 'Champs Frechets', '+061766195268', 'clinique_Champs Frechets@test.com', '+615795046083', '', '', '', 2, NULL, 0),
(35, 'Pharmacie Cina', '+520809650584', 'clinique_Pharmacie Cina@test.com', '+627908853638', '', '', '', 2, NULL, 0),
(36, 'Pharmacie D\'Herborence', '+968622422960', 'clinique_Pharmacie D\'Herborence@test.com', '+097116807445', '', '', '', 2, NULL, 0),
(37, 'Pharmacie d\'Orsières', '+692282583864', 'clinique_Pharmacie d\'Orsières@test.com', '+061282549883', '', '', '', 2, NULL, 0),
(38, 'Pharmacie de Clarens', '+214341281036', 'clinique_Pharmacie de Clarens@test.com', '+138030613935', '', '', '', 2, NULL, 0),
(39, 'Pharmacie de Cortot', '+538423197248', 'clinique_Pharmacie de Cortot@test.com', '+348004847368', '', '', '', 2, NULL, 0),
(40, 'Pharmacie de Florissant - Renens', '+200751004123', 'clinique_Pharmacie de Florissant - Renens@test.com', '+598787527828', '', '', '', 2, NULL, 0),
(41, 'Pharmacie de l\'ile à Rolle', '+352633705702', 'clinique_Pharmacie de l\'ile à Rolle@test.com', '+470962699400', '', '', '', 2, NULL, 0),
(42, 'Pharmacie du Tilleul', '+874294629296', 'clinique_Pharmacie du Tilleul@test.com', '+598947959808', '', '', '', 2, NULL, 0),
(43, 'Pharmacie Saint-Léger', '+175318599265', 'clinique_Pharmacie Saint-Léger@test.com', '+889850002896', '', '', '', 2, NULL, 0),
(44, 'Pharmacie Populaire - Officine : Varembe', '+692594758772', 'clinique_Pharmacie Populaire - Officine : Varembe@test.com', '+001756608661', '', '', '', 2, NULL, 0),
(45, 'Pharmacie Populaire - Officine : Trois-Chêne', '+769023568797', 'clinique_Pharmacie Populaire - Officine : Trois-Chêne@test.com', '+593020765572', '', '', '', 2, NULL, 0),
(46, 'Pharmacie Chablais-Gare', '+998051483056', 'clinique_Pharmacie Chablais-Gare@test.com', '+164478841427', '', '', '', 2, NULL, 0),
(47, 'Salveo', '+363739989222', 'clinique_Salveo@test.com', '+687314184785', '', '', '', 2, NULL, 0),
(48, 'Pharmapro', '+833276866503', 'clinique_Pharmapro@test.com', '+390532057726', '', '', '', 2, NULL, 0),
(49, 'Pharmacies de Garde à Martigny', '+646009066532', 'clinique_Pharmacies de Garde à Martigny@test.com', '+701168348191', '', '', '', 2, NULL, 0),
(50, 'AXA', '+194406715545', 'insurance_@test.com', '+554526248568', '', '', '', 3, NULL, 0),
(51, 'CSS', '+891930106715', 'insurance_@test.com', '+034109087611', '', '', '', 3, NULL, 0),
(52, 'Groupe Mutuel Philos', '+492348540960', 'insurance_@test.com', '+489498075366', '', '', '', 3, NULL, 0),
(53, 'General Lee', '+030768925078', 'insurance_@test.com', '+249519213792', '', '', '', 3, NULL, 0),
(54, 'Assura', '+495681495247', 'insurance_@test.com', '+295192977137', '', '', '', 3, NULL, 0),
(55, 'SUVA', '+381360107450', 'insurance_@test.com', '+263682666873', '', '', '', 3, NULL, 0),
(56, 'Helsana', '+365657723950', 'insurance_@test.com', '+726530722413', '', '', '', 3, NULL, 0),
(57, 'Concordia', '+192740301996', 'insurance_@test.com', '+555650539380', '', '', '', 3, NULL, 0),
(58, 'Sanitas', '+448917556481', 'insurance_@test.com', '+791127799038', '', '', '', 3, NULL, 0),
(59, 'KPT/CPT Holding', '+153813224571', 'insurance_@test.com', '+700683107625', '', '', '', 3, NULL, 0),
(60, 'Wincare', '+313581089416', 'insurance_@test.com', '+354715186406', '', '', '', 3, NULL, 0),
(61, 'Atupri', '+044219923648', 'insurance_@test.com', '+997772232462', '', '', '', 3, NULL, 0),
(62, 'ÖKK', '+938374270879', 'insurance_@test.com', '+015032472596', '', '', '', 3, NULL, 0),
(63, 'EGK-Gesundheitskasse', '+182848154247', 'insurance_@test.com', '+454791181989', '', '', '', 3, NULL, 0),
(64, 'Sympany', '+406156053924', 'insurance_@test.com', '+781682093686', '', '', '', 3, NULL, 0),
(65, 'Sansan Versicherungen', '+513273508534', 'insurance_@test.com', '+523364523549', '', '', '', 3, NULL, 0),
(66, 'Agrisano', '+977337876361', 'insurance_@test.com', '+541684172553', '', '', '', 3, NULL, 0),
(67, 'Avanex', '+413210653607', 'insurance_@test.com', '+536410263484', '', '', '', 3, NULL, 0),
(68, 'Carena Schweiz', '+933592652557', 'insurance_@test.com', '+149150258790', '', '', '', 3, NULL, 0),
(69, 'Fondation AMB', '+474194919430', 'insurance_@test.com', '+117201809589', '', '', '', 3, NULL, 0),
(70, 'AXA', '+611845706208', 'insurance_AXA@test.com', '+929853306783', '', '', '', 3, NULL, 0),
(71, 'CSS', '+808432860829', 'insurance_CSS@test.com', '+921723870510', '', '', '', 3, NULL, 0),
(72, 'Groupe Mutuel Philos', '+725690310333', 'insurance_Groupe Mutuel Philos@test.com', '+237342655600', '', '', '', 3, NULL, 0),
(73, 'General Lee', '+721933531349', 'insurance_General Lee@test.com', '+936144535447', '', '', '', 3, NULL, 0),
(74, 'Assura', '+456074408337', 'insurance_Assura@test.com', '+777660451058', '', '', '', 3, NULL, 0),
(75, 'SUVA', '+325896620978', 'insurance_SUVA@test.com', '+090133305784', '', '', '', 3, NULL, 0),
(76, 'Helsana', '+568063087804', 'insurance_Helsana@test.com', '+009758063619', '', '', '', 3, NULL, 0),
(77, 'Concordia', '+569998665872', 'insurance_Concordia@test.com', '+747479434953', '', '', '', 3, NULL, 0),
(78, 'Sanitas', '+156054988632', 'insurance_Sanitas@test.com', '+278165485168', '', '', '', 3, NULL, 0),
(79, 'KPT/CPT Holding', '+382540519213', 'insurance_KPT/CPT Holding@test.com', '+944355579605', '', '', '', 3, NULL, 0),
(80, 'Wincare', '+810064865909', 'insurance_Wincare@test.com', '+080477503601', '', '', '', 3, NULL, 0),
(81, 'Atupri', '+663904227030', 'insurance_Atupri@test.com', '+365339035983', '', '', '', 3, NULL, 0),
(82, 'ÖKK', '+235604107078', 'insurance_ÖKK@test.com', '+654016171147', '', '', '', 3, NULL, 0),
(83, 'EGK-Gesundheitskasse', '+438853170464', 'insurance_EGK-Gesundheitskasse@test.com', '+087358402892', '', '', '', 3, NULL, 0),
(84, 'Sympany', '+017081958356', 'insurance_Sympany@test.com', '+558232951161', '', '', '', 3, NULL, 0),
(85, 'Sansan Versicherungen', '+001987511899', 'insurance_Sansan Versicherungen@test.com', '+462944710162', '', '', '', 3, NULL, 0),
(86, 'Agrisano', '+277080926374', 'insurance_Agrisano@test.com', '+186367597503', '', '', '', 3, NULL, 0),
(87, 'Avanex', '+855253802341', 'insurance_Avanex@test.com', '+551091478270', '', '', '', 3, NULL, 0),
(88, 'Carena Schweiz', '+686144602094', 'insurance_Carena Schweiz@test.com', '+809586284518', '', '', '', 3, NULL, 0),
(89, 'Fondation AMB', '+849316188559', 'insurance_Fondation AMB@test.com', '+538748019187', '', '', '', 3, NULL, 0),
(90, 'Fondation Rive-Neuve', '+712150062487', 'otherhealthcare_Fondation Rive-Neuve@test.com', '+764509487066', '', '', '', 4, NULL, 0),
(91, 'OMSV', '+182367759340', 'otherhealthcare_OMSV@test.com', '+024309775298', '', '', '', 4, NULL, 0),
(92, 'ASI Section Vaud', '+098637815245', 'otherhealthcare_ASI Section Vaud@test.com', '+391780541955', '', '', '', 4, NULL, 0),
(93, 'ARLD', '+739169721348', 'otherhealthcare_ARLD@test.com', '+083966145104', '', '', '', 4, NULL, 0),
(94, 'PhisioSwiss', '+158418879508', 'otherhealthcare_PhisioSwiss@test.com', '+595233216952', '', '', '', 4, NULL, 0),
(95, 'SVMED', '+860551694994', 'otherhealthcare_SVMED@test.com', '+089185716431', '', '', '', 4, NULL, 0),
(96, 'SVMD', '+383387172987', 'otherhealthcare_SVMD@test.com', '+203014802670', '', '', '', 4, NULL, 0),
(97, 'Dr Gapany', '+603039901443', 'otherhealthcare_Dr Gapany@test.com', '+541328262801', '', '', '', 4, NULL, 0),
(98, 'Dr René Lysek', '+153362774962', 'otherhealthcare_Dr René Lysek@test.com', '+309665107805', '', '', '', 4, NULL, 0),
(99, 'AVADOL', '+566345769880', 'otherhealthcare_AVADOL@test.com', '+230789199367', '', '', '', 4, NULL, 0),
(100, 'AVSD', '+402764101545', 'otherhealthcare_AVSD@test.com', '+225043958082', '', '', '', 4, NULL, 0),
(101, 'AVADOL', '+837201503685', 'otherhealthcare_AVADOL@test.com', '+446223171414', '', '', '', 4, NULL, 0),
(102, 'PRENDPLACE', '+068020855855', 'otherhealthcare_PRENDPLACE@test.com', '+991541499976', '', '', '', 4, NULL, 0),
(103, 'PSY VS', '+795340908064', 'otherhealthcare_PSY VS@test.com', '+370020012099', '', '', '', 4, NULL, 0),
(104, 'IRO', '+388443777640', 'otherhealthcare_IRO@test.com', '+316349684009', '', '', '', 4, NULL, 0),
(105, 'ASSAL', '+258783320690', 'otherhealthcare_ASSAL@test.com', '+218024617108', '', '', '', 4, NULL, 0),
(106, 'CM Lignon', '+772390291639', 'otherhealthcare_CM Lignon@test.com', '+775234268922', '', '', '', 4, '106.png', 0),
(107, 'CMS Magellan', '+549974371094', 'otherhealthcare_CMS Magellan@test.com', '+524218013328', '', '', '', 4, '107.png', 0),
(108, 'EMS Val Fleuri', '+130661795265', 'otherhealthcare_EMS Val Fleuri@test.com', '+698450344010', '', '', '', 4, '108.png', 0),
(109, 'Fondation Fénix', '+894816754780', 'otherhealthcare_Fondation Fénix@test.com', '+264600037133', '', '', '', 4, '109.png', 0),
(208, 'TYI', '1231231234', 'o@q.r', '23423423454', '4564564567', '4564564567', 'o@q.f', NULL, '208.png', 1),
(214, 'te', '', '', '', '', '', '', NULL, '214.png', 0),
(215, 'FYT', '', '', '', '', '', '', NULL, '215.png', 0),
(216, 'TYI 1', '', '', '', '', '', '', NULL, '216.png', 1),
(217, 'efefrefr', '', '', '', '', '', '', NULL, '217.png', 0),
(218, 'TYS', '', '', '', '', '', '', NULL, NULL, 0),
(219, 'Go Medicine', '0123456789', '', '', '', '', '', NULL, '219.png', 1),
(220, 'Doe Hospital', '789', '', '', '', '', '', NULL, NULL, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalestablishmentbelongtoappointment`
--

CREATE TABLE `t_medicalestablishmentbelongtoappointment` (
  `fkMedicalEstablishment` int(11) NOT NULL,
  `fkAppointment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalestablishmentbelongtoappointment`
--

INSERT INTO `t_medicalestablishmentbelongtoappointment` (`fkMedicalEstablishment`, `fkAppointment`) VALUES
(33, 449),
(46, 449),
(7, 449),
(26, 449),
(89, 449),
(13, 449),
(15, 449),
(17, 449),
(18, 449),
(20, 449),
(19, 449),
(14, 449),
(16, 449),
(21, 449),
(22, 449),
(23, 449),
(24, 449),
(25, 449),
(28, 449),
(30, 449),
(31, 449),
(32, 449),
(34, 449),
(35, 449),
(36, 449),
(37, 449),
(38, 449),
(215, 449);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalestablishmenthaslinkwithpatient`
--

CREATE TABLE `t_medicalestablishmenthaslinkwithpatient` (
  `idxMedicalEstablishment` int(11) NOT NULL,
  `idxPatient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalestablishmenthastype`
--

CREATE TABLE `t_medicalestablishmenthastype` (
  `id` int(11) NOT NULL,
  `fkMedicalEstablishmentType` int(11) NOT NULL,
  `fkMedicalEstablishment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalestablishmenthastype`
--

INSERT INTO `t_medicalestablishmenthastype` (`id`, `fkMedicalEstablishmentType`, `fkMedicalEstablishment`) VALUES
(1, 48, 208),
(2, 2, 208),
(3, 49, 208),
(4, 49, 209),
(5, 49, 210),
(6, 49, 214),
(7, 49, 215),
(8, 49, 216),
(9, 4, 218),
(10, 2, 219),
(11, 48, 220);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalestablishmenttype`
--

CREATE TABLE `t_medicalestablishmenttype` (
  `idMedicalEstablishmentType` int(11) NOT NULL,
  `medesttypeName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalestablishmenttype`
--

INSERT INTO `t_medicalestablishmenttype` (`idMedicalEstablishmentType`, `medesttypeName`) VALUES
(1, 'Clinique'),
(2, 'Pharmacy'),
(3, 'Other healthcare'),
(4, 'Cataloge'),
(48, 'hospital'),
(49, 'test');

-- --------------------------------------------------------

--
-- Table structure for table `t_medicalprescription`
--

CREATE TABLE `t_medicalprescription` (
  `idMedicalPrescription` int(11) NOT NULL,
  `fkPatients` int(6) NOT NULL,
  `fkConsultations` int(6) NOT NULL,
  `fkMedicament` int(6) NOT NULL,
  `medEveryValue` int(11) NOT NULL,
  `medEveryUnit` varchar(255) NOT NULL,
  `medWhileValue` int(11) NOT NULL,
  `medWhileUnit` varchar(255) NOT NULL,
  `medTakeMorning` varchar(225) NOT NULL,
  `medTakeMidDay` varchar(225) NOT NULL,
  `medTakeEvening` varchar(225) NOT NULL,
  `medTakeNight` varchar(225) NOT NULL,
  `medReserve` tinyint(1) NOT NULL,
  `medUsual` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicalprescription`
--

INSERT INTO `t_medicalprescription` (`idMedicalPrescription`, `fkPatients`, `fkConsultations`, `fkMedicament`, `medEveryValue`, `medEveryUnit`, `medWhileValue`, `medWhileUnit`, `medTakeMorning`, `medTakeMidDay`, `medTakeEvening`, `medTakeNight`, `medReserve`, `medUsual`) VALUES
(7, 91, 33, 8, 31, 'Semaine', 4, 'Semaine', 'null', '{"time":{"h":"12","m":"00"},"beforeMeal":"false","quantity":"12"}', 'null', 'null', 0, 0),
(8, 91, 33, 2, 31, 'Semaine', 4, 'Semaine', 'null', '{"time":{"h":"12","m":"00"},"beforeMeal":"false","quantity":"1"}', 'null', 'null', 0, 0),
(9, 17, 34, 17, 1, 'Semaine', 3, 'Semaine', '{"time":{"h":"07","m":"30"},"beforeMeal":"false","quantity":"1"}', '{"time":{"h":"12","m":"00"},"beforeMeal":"false","quantity":"1"}', '{"time":{"h":"17","m":"00"},"beforeMeal":"false","quantity":"2"}', 'null', 0, 0),
(10, 17, 34, 12, 2, 'Semaine', 2, 'Semaine', '{"time":{"h":"07","m":"30"},"beforeMeal":"false","quantity":"1"}', 'null', 'null', 'null', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `t_medicament`
--

CREATE TABLE `t_medicament` (
  `idMedicament` int(11) NOT NULL,
  `medName` varchar(255) NOT NULL,
  `medQuantity` varchar(255) NOT NULL,
  `medHandoverCat` varchar(255) NOT NULL,
  `medPrice` decimal(4,2) NOT NULL,
  `medRefundCat` varchar(255) NOT NULL,
  `medPharmacode` varchar(255) NOT NULL,
  `medGTIN` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_medicament`
--

INSERT INTO `t_medicament` (`idMedicament`, `medName`, `medQuantity`, `medHandoverCat`, `medPrice`, `medRefundCat`, `medPharmacode`, `medGTIN`) VALUES
(1, 'Simvastatin', '20', '0', '99.99', '0', '20010', '97916'),
(2, 'Aspirin', '10', '0', '99.99', '0', '27717', '75836'),
(3, 'Omeprazole', '7', '0', '99.99', '0', '37516', '69990'),
(4, 'Levothyroxine Sodium', '1', '0', '99.99', '0', '76236', '83880'),
(5, 'Ramipril', '16', '0', '99.99', '0', '30602', '25712'),
(6, 'Amlodipine', '10', '0', '99.99', '0', '65199', '57364'),
(7, 'Paracetamol', '1', '0', '99.99', '0', '71343', '95122'),
(8, 'Atorvastatin', '5', '0', '99.99', '0', '78363', '24008'),
(9, 'Salbutamol', '4', '0', '99.99', '0', '53344', '51500'),
(10, 'Lansoprazole', '15', '0', '99.99', '0', '10940', '10965'),
(11, 'Metformin Hydrochloride', '8', '0', '99.99', '0', '80917', '86673'),
(12, 'Cholecalciferol', '13', '0', '99.99', '0', '51923', '35719'),
(13, 'Bisoprolol fumarate', '9', '0', '99.99', '0', '30528', '48785'),
(14, 'Co-codamol', '3', '0', '99.99', '0', '93039', '40734'),
(15, 'Bendroflumethiazide', '10', '0', '99.99', '0', '42999', '90936'),
(16, 'Citalopram hydrobromide', '14', '0', '99.99', '0', '75202', '20844'),
(17, 'Amoxicillin', '4', '0', '99.99', '0', '79565', '69883'),
(18, 'Furosemide', '6', '0', '99.99', '0', '71960', '21538'),
(19, 'Amitriptyline hydrochloride', '3', '0', '99.99', '0', '62686', '17801'),
(20, 'Warfarin sodium', '12', '0', '99.99', '0', '29550', '27440');

-- --------------------------------------------------------

--
-- Table structure for table `t_otherhealthcare`
--

CREATE TABLE `t_otherhealthcare` (
  `idOtherhealthcare` int(4) NOT NULL,
  `othName` varchar(50) NOT NULL,
  `othCity` int(4) NOT NULL,
  `othMainPhone` int(15) NOT NULL,
  `othPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_otherhealthcare`
--

INSERT INTO `t_otherhealthcare` (`idOtherhealthcare`, `othName`, `othCity`, `othMainPhone`, `othPhoto`) VALUES
(0, 'Fondation Rive-Neuve', 8, 2147483647, ''),
(2, 'OMSV', 19, 2147483647, ''),
(3, 'ASI Section Vaud', 18, 2147483647, ''),
(4, 'ARLD', 5, 2147483647, ''),
(5, 'PhisioSwiss', 8, 2147483647, ''),
(6, 'SVMED', 2, 2147483647, ''),
(7, 'SVMD', 8, 2147483647, ''),
(8, 'Dr Gapany', 15, 2147483647, ''),
(9, 'Dr René Lysek', 5, 2147483647, ''),
(10, 'AVADOL', 6, 2147483647, ''),
(11, 'AVSD', 5, 2147483647, ''),
(12, 'AVADOL', 5, 2147483647, ''),
(13, 'PRENDPLACE', 19, 2147483647, ''),
(14, 'PSY VS', 11, 2147483647, ''),
(15, 'IRO', 5, 2147483647, ''),
(16, 'ASSAL', 9, 2147483647, ''),
(17, 'CM Lignon', 1, 2147483647, ''),
(18, 'CMS Magellan', 1, 2147483647, ''),
(19, 'EMS Val Fleuri', 2, 2147483647, ''),
(20, 'Fondation Fénix', 13, 2147483647, '');

-- --------------------------------------------------------

--
-- Table structure for table `t_otherhealthcarebelongtoappointment`
--

CREATE TABLE `t_otherhealthcarebelongtoappointment` (
  `idAppointment` int(11) NOT NULL,
  `id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_othermedicalhistory`
--

CREATE TABLE `t_othermedicalhistory` (
  `idOtherMedicalHistory` int(11) NOT NULL,
  `othmedhisDescription` varchar(100) CHARACTER SET latin1 NOT NULL,
  `fkPatient` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_othermedicalhistory`
--

INSERT INTO `t_othermedicalhistory` (`idOtherMedicalHistory`, `othmedhisDescription`, `fkPatient`) VALUES
(1, 'Other medical history', 155),
(2, 'dsggsdg', 167),
(3, 'Other medical history', 168);

-- --------------------------------------------------------

--
-- Table structure for table `t_patient`
--

CREATE TABLE `t_patient` (
  `idPatient` int(4) NOT NULL,
  `patProfilePic` varchar(100) DEFAULT NULL,
  `patName` varchar(50) NOT NULL,
  `patLastname` varchar(180) NOT NULL,
  `patBirthDate` date DEFAULT NULL,
  `patGender` char(1) DEFAULT NULL,
  `patCivilStatus` varchar(255) DEFAULT NULL,
  `patMainPhone` varchar(15) DEFAULT NULL,
  `patSecPhone` varchar(20) DEFAULT NULL,
  `patMainMail` varchar(60) DEFAULT NULL,
  `patSecMail` varchar(60) DEFAULT NULL,
  `patPhoto` varchar(255) DEFAULT NULL,
  `patIsFavorite` tinyint(1) DEFAULT NULL,
  `patSocialSecurityNumber` varchar(255) DEFAULT NULL,
  `patAIRate` varchar(10) DEFAULT NULL,
  `patAIStartDate` date DEFAULT NULL,
  `patAVS` varchar(50) DEFAULT NULL,
  `patCanSendMail` tinyint(1) DEFAULT NULL,
  `patCanSendPost` tinyint(1) DEFAULT NULL,
  `fkContactAsAIOffice` int(11) DEFAULT NULL,
  `patAIComment` varchar(250) DEFAULT NULL,
  `fkPatientAsLegalRepresentative` int(11) DEFAULT NULL,
  `fkContactAsLegalRepresentative` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patient`
--

INSERT INTO `t_patient` (`idPatient`, `patProfilePic`, `patName`, `patLastname`, `patBirthDate`, `patGender`, `patCivilStatus`, `patMainPhone`, `patSecPhone`, `patMainMail`, `patSecMail`, `patPhoto`, `patIsFavorite`, `patSocialSecurityNumber`, `patAIRate`, `patAIStartDate`, `patAVS`, `patCanSendMail`, `patCanSendPost`, `fkContactAsAIOffice`, `patAIComment`, `fkPatientAsLegalRepresentative`, `fkContactAsLegalRepresentative`) VALUES
(1, '', 'Gian', 'Doe', '1968-07-22', 'f', '', '+719208336394', '', NULL, '', 'https://picsum.photos/50/50?image=915', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(2, '', 'Valentin', '', '1914-06-20', 'm', '', '+452608956953', '', '', '', 'https://picsum.photos/50/50?image=920', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(3, '', 'Adrian', '', '1917-10-13', 'f', '', '+791178939054', '', '', '', 'https://picsum.photos/50/50?image=856', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(4, '', 'Lukas', '', '1983-11-23', 'm', '', '+694379938906', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(5, '', 'Valentin', '', '1942-09-11', 'f', '', '+741812673764', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(6, '', 'Levi', '', '1975-07-19', 'm', '', '+286904440087', '', '', '', 'https://picsum.photos/50/50?image=652', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(7, '', 'Jason', 'Monson', '1953-09-26', 'f', '', '+091202587975', '', '', '', 'https://picsum.photos/50/50?image=128', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(8, '', 'Hugo', '', '1951-10-10', 'm', '', '+656211741104', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(9, '', 'Lucas', '', '1940-12-19', 'f', '', '+754439642168', '', '', '', 'https://picsum.photos/50/50?image=49', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(10, '', 'Luis', '', '1943-02-12', 'm', '', '+039340381928', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(11, '', 'Laurin', '', '1964-12-27', 'f', '', '+407206998963', '', '', '', 'https://picsum.photos/50/50?image=783', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(12, '', 'Joshua', '', '1974-11-10', 'm', '', '+803654700697', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(13, '', 'Manuel', '', '1990-07-28', 'f', '', '+409138352947', '', '', '', 'https://picsum.photos/50/50?image=441', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(14, '', 'Luis', '', '1928-06-15', 'm', '', '+184906967451', '', '', '', 'https://picsum.photos/50/50?image=131', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(15, '', 'Alex', '', '1914-03-13', 'f', '', '+937319430643', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(16, '', 'Fabio', '', '1976-06-28', 'm', '', '+577119115225', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(17, '', 'Adam', '', '1961-01-16', 'f', '', '+275775516341', '', '', '', 'https://picsum.photos/50/50?image=325', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(18, '', 'Alexander', '', '1947-10-12', 'm', '', '+147568796740', '', '', '', 'https://picsum.photos/50/50?image=835', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(19, '', 'Fabian', '', '1975-07-14', 'f', '', '+455253311690', '', '', '', 'https://picsum.photos/50/50?image=201', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(20, '', 'Lars', '', '1969-02-10', 'm', '', '+293828974699', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(21, '', 'Linus', '', '1940-01-25', 'f', '', '+841799625914', '', '', '', 'https://picsum.photos/50/50?image=902', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(22, '', 'Ryan', '', '1926-09-25', 'm', '', '+573457709665', '', '', '', 'https://picsum.photos/50/50?image=7', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(23, '', 'Nathan', '', '1915-02-10', 'f', '', '+952882928599', '', '', '', 'https://picsum.photos/50/50?image=329', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(24, '', 'Luca', '', '1923-02-27', 'm', '', '+220108826181', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(25, '', 'Nolan', '', '1933-10-05', 'f', '', '+528771020498', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(26, '', 'David', '', '1932-02-22', 'm', '', '+110338684494', '', '', '', 'https://picsum.photos/50/50?image=813', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(27, '', 'Timo', '', '1931-04-20', 'f', '', '+027863012114', '', '', '', 'https://picsum.photos/50/50?image=654', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(28, '', 'David', '', '1951-06-23', 'm', '', '+701533918623', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(29, '', 'Elias', '', '1960-08-07', 'f', '', '+184998558113', '', '', '', 'https://picsum.photos/50/50?image=197', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(30, '', 'Manuel', '', '1936-02-13', 'm', '', '+102076662559', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(31, '', 'Andrin', '', '1983-11-25', 'f', '', '+674902495486', '', '', '', 'https://picsum.photos/50/50?image=867', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(32, '', 'Nino', '', '1967-10-03', 'm', '', '+935694860565', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(33, '', 'Ajan', '', '1993-06-09', 'f', '', '+902702521794', '', '', '', 'https://picsum.photos/50/50?image=700', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(34, '', 'Ben', '', '1929-07-23', 'm', '', '+832931519287', '', '', '', 'https://picsum.photos/50/50?image=919', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(35, '', 'Nolan', '', '1942-09-06', 'f', '', '+971674870416', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(36, '', 'Louis', '', '1990-12-27', 'm', '', '+444895023700', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(37, '', 'Nathan', '', '1997-01-05', 'f', '', '+919267420613', '', '', '', 'https://picsum.photos/50/50?image=109', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(38, '', 'Andrin', '', '1976-05-12', 'm', '', '+726560646244', '', '', '', 'https://picsum.photos/50/50?image=391', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(39, '', 'Paul', '', '1901-11-08', 'f', '', '+011085354993', '', '', '', 'https://picsum.photos/50/50?image=629', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(40, '', 'Kevin', '', '1970-09-18', 'm', '', '+045887634256', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(41, '', 'Nino', '', '1980-03-20', 'f', '', '+325779935530', '', '', '', 'https://picsum.photos/50/50?image=980', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(42, '', 'Luca', '', '1976-10-15', 'm', '', '+089371733504', '', '', '', 'https://picsum.photos/50/50?image=982', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(43, '', 'Elia', '', '1924-09-21', 'f', '', '+128884867993', '', '', '', 'https://picsum.photos/50/50?image=968', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(44, '', 'Arthur', '', '1965-01-08', 'm', '', '+988691655700', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(45, '', 'Nicolas', '', '1918-02-02', 'f', '', '+107565604739', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(46, '', 'Lucas', '', '1987-03-16', 'm', '', '+818549966093', '', '', '', 'https://picsum.photos/50/50?image=199', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(47, '', 'Nico', '', '1908-10-15', 'f', '', '+505269135008', '', '', '', 'https://picsum.photos/50/50?image=263', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(48, '', 'Julian', '', '1933-02-17', 'm', '', '+275631530298', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(49, '', 'Ethan', '', '1960-03-12', 'f', '', '+051185894998', '', '', '', 'https://picsum.photos/50/50?image=807', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(50, '', 'Lio', '', '1927-02-28', 'm', '', '+704821389434', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(51, '', 'Louis', '', '1947-05-18', 'f', '', '+030849741567', '', '', '', 'https://picsum.photos/50/50?image=968', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(52, '', 'Luan', '', '1987-06-25', 'm', '', '+925293463488', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(53, '', 'Paul', '', '1986-09-01', 'f', '', '+008790481291', '', '', '', 'https://picsum.photos/50/50?image=128', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(54, '', 'Elia', '', '1986-04-27', 'm', '', '+085469683039', '', '', '', 'https://picsum.photos/50/50?image=24', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(55, '', 'Leo', '', '1976-12-20', 'f', '', '+619362197502', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(56, '', 'Dylan', '', '1948-04-06', 'm', '', '+219117857645', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(57, '', 'Jan', '', '1996-04-11', 'f', '', '+787444022601', '', '', '', 'https://picsum.photos/50/50?image=799', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(58, '', 'Luan', '', '1916-09-25', 'm', '', '+987307329283', '', '', '', 'https://picsum.photos/50/50?image=194', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(59, '', 'Hugo', '', '1936-03-25', 'f', '', '+839871762758', '', '', '', 'https://picsum.photos/50/50?image=575', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(60, '', 'Lio', '', '1972-01-04', 'm', '', '+795685340481', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(61, '', 'Loris', '', '1940-09-04', 'f', '', '+750665135234', '', '', '', 'https://picsum.photos/50/50?image=734', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(62, '', 'Adrian', '', '1961-09-21', 'm', '', '+133475709674', '', '', '', 'https://picsum.photos/50/50?image=794', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(63, '', 'Mattia', '', '1954-07-27', 'f', '', '+355930823585', '', '', '', 'https://picsum.photos/50/50?image=771', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(64, '', 'Leo', '', '1912-10-20', 'm', '', '+807859229328', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(65, '', 'Rafael', '', '1911-06-24', 'f', '', '+734299481451', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(66, '', 'Leandro', '', '1984-10-07', 'm', '', '+470110994724', '', '', '', 'https://picsum.photos/50/50?image=812', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(67, '', 'Nico', '', '1981-06-21', 'f', '', '+913358430387', '', '', '', 'https://picsum.photos/50/50?image=926', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(68, '', 'Max', '', '1940-10-19', 'm', '', '+449172395065', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(69, '', 'Nino', '', '1998-12-24', 'f', '', '+720445408622', '', '', '', 'https://picsum.photos/50/50?image=184', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(70, '', 'Elia', '', '1935-03-04', 'm', '', '+459004998603', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(71, '', 'Moritz', '', '1991-03-05', 'f', '', '+252270986820', '', '', '', 'https://picsum.photos/50/50?image=164', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(72, '', 'Nico', '', '1933-02-22', 'm', '', '+930651009107', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(73, '', 'Nino', '', '1937-07-22', 'f', '', '+082185531778', '', '', '', 'https://picsum.photos/50/50?image=462', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(74, '', 'Luca', '', '1906-01-02', 'm', '', '+640231554175', '', '', '', 'https://picsum.photos/50/50?image=937', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(75, '', 'Julian', '', '1913-07-04', 'f', '', '+846527682150', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(76, '', 'Adam', 'Bobowicz', '1906-12-20', 'm', '', '+866815366083', '', 'adam_bobowicz@mail.ch', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(77, '', 'Alex', '', '1960-11-20', 'f', '', '+699996393401', '', '', '', 'https://picsum.photos/50/50?image=586', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(78, '', 'Manuel', '', '1978-10-21', 'm', '', '+889238930842', '', '', '', 'https://picsum.photos/50/50?image=835', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(79, '', 'Felix', '', '1916-08-22', 'f', '', '+489197713225', '', '', '', 'https://picsum.photos/50/50?image=418', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(80, '', 'Jonas', '', '1990-03-12', 'm', '', '+189054115039', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(81, '', 'Valentin', '', '1937-08-01', 'f', '', '+418654704614', '', '', '', 'https://picsum.photos/50/50?image=670', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(82, '', 'Levin', '', '1915-09-07', 'm', '', '+490992522624', '', '', '', 'https://picsum.photos/50/50?image=596', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(83, '', 'Adrian', '', '1900-04-11', 'f', '', '+795974109264', '', '', '', 'https://picsum.photos/50/50?image=973', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(84, '', 'Simon', '', '1903-01-07', 'm', '', '+718451778424', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(85, '', 'Lio', '', '1993-12-03', 'f', '', '+738273864538', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(86, '', 'Nolan', '', '1946-02-03', 'm', '', '+143317381187', '', '', '', 'https://picsum.photos/50/50?image=49', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(87, '', 'Kilian', '', '1919-09-25', 'f', '', '+532952160971', '', '', '', 'https://picsum.photos/50/50?image=882', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(88, '', 'Lean', '', '1923-08-07', 'm', '', '+298628702336', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(89, '', 'Maximilian', '', '1939-04-09', 'f', '', '+445385666130', '', '', '', 'https://picsum.photos/50/50?image=671', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(90, '', 'Dario', '', '1964-04-14', 'm', '', '+194425090147', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(91, '', 'Adam', 'Adamaman', '1951-02-06', 'f', '', '+827043122899', '', '', '', 'https://picsum.photos/50/50?image=823', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(92, '', 'Emil', '', '1954-02-04', 'm', '', '+652218343017', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(93, '', 'Maxime', '', '1913-04-06', 'f', '', '+923472722660', '', '', '', 'https://picsum.photos/50/50?image=605', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(94, '', 'Joshua', '', '1909-10-23', 'm', '', '+015637844209', '', '', '', 'https://picsum.photos/50/50?image=782', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(95, '', 'Arthur', '', '1963-09-20', 'f', '', '+801955191754', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(96, '', 'Kevin', '', '1937-10-19', 'm', '', '+602812168564', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(97, '', 'Valentin', '', '1905-04-06', 'f', '', '+296163180346', '', '', '', 'https://picsum.photos/50/50?image=360', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(98, '', 'Livio', '', '1921-06-19', 'm', '', '+974357241387', '', '', '', 'https://picsum.photos/50/50?image=416', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(99, '', 'Diego', '', '1988-06-17', 'f', '', '+054509725250', '', '', '', 'https://picsum.photos/50/50?image=997', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(100, '', 'Lenny', '', '1958-02-01', 'm', '', '+422956949198', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(101, '', 'Robin', '', '1963-02-21', 'f', '', '+637439173930', '', '', '', 'https://picsum.photos/50/50?image=708', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(102, '', 'Noe', '', '1920-11-21', 'm', '', '+680338905507', '', '', '', 'https://picsum.photos/50/50?image=323', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(103, '', 'Lorik', '', '1911-04-09', 'f', '', '+729773870119', '', '', '', 'https://picsum.photos/50/50?image=489', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(104, '', 'Noe', '', '1959-01-08', 'm', '', '+730971372305', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(105, '', 'Fabio', '', '1927-08-05', 'f', '', '+126550074573', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(106, '', 'Gabriel', '', '1995-04-23', 'm', '', '+444476864705', '', '', '', 'https://picsum.photos/50/50?image=130', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(107, '', 'Diego', '', '1995-06-08', 'f', '', '+623945146827', '', '', '', 'https://picsum.photos/50/50?image=917', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(108, '', 'Loris', '', '1901-04-13', 'm', '', '+892489944664', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(109, '', 'Nathan', '', '1935-06-03', 'f', '', '+383981260984', '', '', '', 'https://picsum.photos/50/50?image=229', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(110, '', 'Alexander', '', '1910-04-04', 'm', '', '+354780784064', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(111, '', 'Levi', '', '1981-09-26', 'f', '', '+118111595321', '', '', '', 'https://picsum.photos/50/50?image=100', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(112, '', 'Julian', '', '1949-10-10', 'm', '', '+369197559913', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(113, '', 'Leon', '', '1947-04-03', 'f', '', '+277603911425', '', '', '', 'https://picsum.photos/50/50?image=844', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(114, '', 'Rafael', '', '1950-04-25', 'm', '', '+532938923254', '', '', '', 'https://picsum.photos/50/50?image=735', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(115, '', 'Leano', '', '1958-04-15', 'f', '', '+657290381982', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(116, '', 'Tim', '', '1980-06-28', 'm', '', '+198259572567', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(117, '', 'Emil', '', '1950-07-09', 'f', '', '+695407259378', '', '', '', 'https://picsum.photos/50/50?image=103', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(118, '', 'Luan', '', '1979-02-04', 'm', '', '+403443535237', '', '', '', 'https://picsum.photos/50/50?image=997', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(119, '', 'Timo', '', '1930-02-22', 'f', '', '+878216877696', '', '', '', 'https://picsum.photos/50/50?image=677', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(120, '', 'Alex', '', '1942-10-23', 'm', '', '+823519417820', '', '', '', '', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(121, '', 'Vigler', '', '1956-06-14', 'f', '', '12312312312', '', '', '', 'https://picsum.photos/50/50?image=948', 0, '', NULL, NULL, NULL, NULL, NULL, NULL, '', NULL, NULL),
(128, '128.png', 'AVS', '1', '2014-01-01', 'M', NULL, '0123456789', '9876543210', 'e1@gmail.com', 'e2@gmail.com', NULL, NULL, NULL, '80', '2017-01-01', 'AVS 1', 1, NULL, 1, 'AI Rent', NULL, NULL),
(129, '129.png', 'AVS', '1', '2014-01-01', 'M', NULL, '0123456789', '9876543210', 'e1@gmail.com', 'e2@gmail.com', NULL, NULL, NULL, '80', '2017-01-01', 'AVS 1', 1, NULL, 1, 'AI Rent', 4, NULL),
(130, '130.png', 'AVS', '1', '2014-01-01', 'M', NULL, '0123456789', '9876543210', 'e1@gmail.com', 'e2@gmail.com', NULL, NULL, NULL, '80', '2017-01-01', 'AVS 1', 1, NULL, 1, 'AI Rent', 4, NULL),
(131, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(132, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(133, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(134, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(135, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(136, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(137, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(138, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(139, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(140, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(141, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(142, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(143, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(144, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(145, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(146, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(147, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(148, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(149, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(150, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(151, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(152, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(153, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(154, NULL, 'AVS', '2', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(155, NULL, 'AVS', '5', '2016-01-01', 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, 'AVS 5', NULL, NULL, NULL, NULL, NULL, NULL),
(156, NULL, 'Ansh', 'Pandey', NULL, 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(157, NULL, 'sdg', 'sdg', NULL, 'M', NULL, '436', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(158, NULL, 'test', '1', NULL, 'M', NULL, '35', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(159, NULL, 'asf', 'asf', NULL, 'M', NULL, '436', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(160, '160.png', 'sdf', 'sdf', NULL, 'M', NULL, '23', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(161, NULL, 'Axa', '1', NULL, 'M', NULL, '234', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(162, NULL, 'Aer', 'r', NULL, 'M', NULL, '234', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(163, NULL, 'Aer', 'r', NULL, 'M', NULL, '234', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(164, NULL, 'Aer', 'r', NULL, 'M', NULL, '234', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(165, NULL, 'sdg', 'sdg', NULL, 'M', NULL, '34', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(166, NULL, 'f', 'fd', NULL, 'M', NULL, '11', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(167, NULL, 'fdsf  fdsf', 'sdf', NULL, 'M', NULL, '11', NULL, 'fdsf@sdf.com', NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(168, NULL, 'dsg', 'sdg', NULL, 'M', NULL, '11', NULL, NULL, NULL, NULL, NULL, NULL, '51', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(169, NULL, 'asfa', 'fasf', NULL, 'M', NULL, '11', NULL, NULL, NULL, NULL, NULL, NULL, '0', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(178, NULL, 'saf', 'asf', '2019-02-01', 'M', NULL, '+919558374539', NULL, 'test@test.om', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(179, NULL, 'saf', 'asf', '2019-02-01', 'M', NULL, '+919558374539', NULL, 'test@test.om', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(180, NULL, 'saf', 'asf', '2019-02-01', 'M', NULL, '+919558374539', NULL, 'test@test.om', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(181, NULL, 'saf', 'asf', '2019-02-01', 'M', NULL, '+919558374539', NULL, 'test@test.om', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(182, NULL, 'Patient', '1', '2013-02-06', 'M', NULL, '1234567890', NULL, 'patient1@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(183, NULL, 'Pat', 'One', NULL, 'M', NULL, '0123456789', NULL, 'pat1@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(184, NULL, 'Pat', 'Two', '2019-02-04', 'M', NULL, '0123456789', NULL, 'pat2@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(185, NULL, 'Pat', 'Three', '2019-02-05', 'M', NULL, '0123456789', NULL, 'pat3@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
(186, NULL, 'Pat', '4', '2019-02-12', 'M', NULL, '0123456789', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_patientbelongtoappointment`
--

CREATE TABLE `t_patientbelongtoappointment` (
  `id` int(11) NOT NULL,
  `idAppointment` int(11) NOT NULL,
  `patbeltoappAttendsAsPatient` tinyint(1) NOT NULL DEFAULT '0',
  `patbeltoappReason` varchar(120) DEFAULT NULL,
  `patbeltoappLaw` varchar(120) DEFAULT NULL,
  `patbeltoappLawField` varchar(120) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patientbelongtoappointment`
--

INSERT INTO `t_patientbelongtoappointment` (`id`, `idAppointment`, `patbeltoappAttendsAsPatient`, `patbeltoappReason`, `patbeltoappLaw`, `patbeltoappLawField`) VALUES
(1, 48, 0, '', '', ''),
(1, 64, 0, '', '', ''),
(1, 65, 0, '', '', ''),
(1, 326, 0, '', '', ''),
(1, 329, 0, '', '', ''),
(1, 330, 0, '', '', ''),
(1, 332, 0, '', '', ''),
(1, 338, 0, '', '', ''),
(1, 345, 0, '', '', ''),
(1, 414, 0, '', '', ''),
(1, 415, 0, '', '', ''),
(1, 416, 0, '', '', ''),
(1, 417, 0, '', '', ''),
(1, 418, 0, '', '', ''),
(1, 419, 0, '', '', ''),
(1, 420, 0, '', '', ''),
(1, 421, 0, '', '', ''),
(1, 422, 0, '', '', ''),
(1, 423, 0, '', '', ''),
(1, 424, 0, '', '', ''),
(1, 432, 1, 'Fiverr', '1', '123'),
(1, 433, 1, 'Fiverr', '1', '123'),
(1, 435, 1, 'Fiverr', '1', '123'),
(1, 436, 1, 'Fiverr', '1', '123'),
(1, 438, 1, 'Fiverr 1', '3', '123'),
(1, 439, 1, 'Fiverr 1', '3', '123'),
(1, 440, 1, 'Fiverr 1', '3', '123'),
(1, 441, 1, 'Fiverr 1', '3', '123'),
(1, 442, 0, NULL, '1', NULL),
(1, 443, 0, NULL, '1', NULL),
(1, 444, 0, NULL, '1', NULL),
(1, 445, 0, NULL, '1', NULL),
(1, 446, 0, NULL, '1', NULL),
(1, 447, 0, NULL, '1', NULL),
(1, 448, 0, NULL, '1', NULL),
(1, 451, 0, NULL, '1', NULL),
(1, 452, 0, NULL, '1', NULL),
(1, 453, 0, NULL, '1', NULL),
(1, 454, 0, NULL, '1', NULL),
(2, 442, 0, NULL, '1', NULL),
(3, 49, 0, '', '', ''),
(3, 57, 0, '', '', ''),
(3, 65, 0, '', '', ''),
(3, 66, 0, '', '', ''),
(3, 98, 0, '', '', ''),
(4, 32, 0, '', '', ''),
(4, 56, 0, '', '', ''),
(4, 449, 0, NULL, '1', NULL),
(5, 33, 0, '', '', ''),
(5, 35, 0, '', '', ''),
(5, 36, 0, '', '', ''),
(5, 57, 0, '', '', ''),
(5, 59, 0, '', '', ''),
(5, 61, 0, '', '', ''),
(6, 32, 0, '', '', ''),
(6, 37, 0, '', '', ''),
(6, 50, 0, '', '', ''),
(6, 58, 0, '', '', ''),
(6, 70, 0, '', '', ''),
(7, 62, 0, '', '', ''),
(7, 357, 0, '', '', ''),
(8, 32, 0, '', '', ''),
(8, 51, 0, '', '', ''),
(8, 56, 0, '', '', ''),
(8, 71, 0, '', '', ''),
(8, 99, 0, '', '', ''),
(9, 66, 0, '', '', ''),
(9, 68, 0, '', '', ''),
(10, 32, 0, '', '', ''),
(10, 58, 0, '', '', ''),
(10, 75, 0, '', '', ''),
(11, 58, 0, '', '', ''),
(11, 59, 0, '', '', ''),
(11, 294, 0, '', '', ''),
(11, 429, 0, '', '', ''),
(12, 31, 0, '', '', ''),
(12, 52, 0, '', '', ''),
(12, 72, 0, '', '', ''),
(13, 32, 0, '', '', ''),
(13, 53, 0, '', '', ''),
(13, 60, 0, '', '', ''),
(13, 69, 0, '', '', ''),
(13, 75, 0, '', '', ''),
(14, 32, 0, '', '', ''),
(14, 60, 0, '', '', ''),
(14, 67, 0, '', '', ''),
(15, 15, 0, '', '', ''),
(15, 59, 0, '', '', ''),
(16, 38, 0, '', '', ''),
(16, 55, 0, '', '', ''),
(17, 425, 0, '', '', ''),
(17, 426, 0, '', '', ''),
(17, 428, 0, '', '', ''),
(17, 431, 0, '', '', ''),
(18, 54, 0, '', '', ''),
(19, 61, 0, '', '', ''),
(20, 32, 0, '', '', ''),
(20, 55, 0, '', '', ''),
(21, 32, 0, '', '', ''),
(21, 61, 0, '', '', ''),
(22, 32, 0, '', '', ''),
(26, 74, 0, '', '', ''),
(27, 60, 0, '', '', ''),
(28, 295, 0, '', '', ''),
(30, 62, 0, '', '', ''),
(38, 334, 0, '', '', ''),
(38, 336, 0, '', '', ''),
(45, 41, 0, '', '', ''),
(46, 344, 0, '', '', ''),
(48, 78, 0, '', '', ''),
(62, 73, 0, '', '', ''),
(62, 342, 0, '', '', ''),
(70, 76, 0, '', '', ''),
(74, 77, 0, '', '', ''),
(85, 296, 0, '', '', ''),
(85, 297, 0, '', '', ''),
(85, 298, 0, '', '', ''),
(85, 319, 0, '', '', ''),
(85, 320, 0, '', '', ''),
(85, 321, 0, '', '', ''),
(85, 324, 0, '', '', ''),
(86, 62, 0, '', '', ''),
(91, 341, 0, '', '', ''),
(91, 343, 0, '', '', ''),
(91, 427, 0, '', '', ''),
(94, 65, 0, '', '', ''),
(94, 70, 0, '', '', ''),
(97, 314, 0, '', '', ''),
(97, 315, 0, '', '', ''),
(97, 317, 0, '', '', ''),
(98, 430, 0, '', '', ''),
(99, 64, 0, '', '', ''),
(104, 305, 0, '', '', ''),
(104, 308, 0, '', '', ''),
(104, 309, 0, '', '', ''),
(104, 312, 0, '', '', ''),
(104, 313, 0, '', '', ''),
(107, 63, 0, '', '', ''),
(109, 299, 0, '', '', ''),
(116, 302, 0, '', '', ''),
(116, 303, 0, '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthasallergy`
--

CREATE TABLE `t_patienthasallergy` (
  `idxAllergy` smallint(6) NOT NULL,
  `idxPatient` int(11) NOT NULL,
  `idxUser` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patienthasallergy`
--

INSERT INTO `t_patienthasallergy` (`idxAllergy`, `idxPatient`, `idxUser`) VALUES
(1, 154, NULL),
(1, 155, NULL),
(2, 154, NULL),
(3, 165, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthaschronicdisease`
--

CREATE TABLE `t_patienthaschronicdisease` (
  `idxChronicDisease` smallint(6) NOT NULL,
  `idxPatient` int(11) NOT NULL,
  `idxUser` smallint(6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patienthaschronicdisease`
--

INSERT INTO `t_patienthaschronicdisease` (`idxChronicDisease`, `idxPatient`, `idxUser`) VALUES
(1, 154, NULL),
(1, 155, NULL),
(2, 165, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthasdrugintolerance`
--

CREATE TABLE `t_patienthasdrugintolerance` (
  `idxDrugIntolerance` smallint(6) NOT NULL,
  `idxPatient` int(11) NOT NULL,
  `idxUser` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patienthasdrugintolerance`
--

INSERT INTO `t_patienthasdrugintolerance` (`idxDrugIntolerance`, `idxPatient`, `idxUser`) VALUES
(1, 154, NULL),
(2, 155, NULL),
(3, 165, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthasinsurance`
--

CREATE TABLE `t_patienthasinsurance` (
  `patHasInsId` int(11) NOT NULL,
  `fkPatient` int(11) NOT NULL,
  `fkInsurance` int(11) NOT NULL,
  `pathasinsIsLamal` tinyint(1) DEFAULT NULL,
  `pathasinsIsAccident` tinyint(1) DEFAULT NULL,
  `pathasinsIsComplementary` tinyint(1) DEFAULT NULL,
  `pathasinsCoverageStartDate` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patienthasinsurance`
--

INSERT INTO `t_patienthasinsurance` (`patHasInsId`, `fkPatient`, `fkInsurance`, `pathasinsIsLamal`, `pathasinsIsAccident`, `pathasinsIsComplementary`, `pathasinsCoverageStartDate`) VALUES
(1, 128, 1, 1, 1, 1, '2016-01-01'),
(2, 128, 3, 1, 1, NULL, '2018-01-01'),
(3, 129, 1, 1, 1, 1, '2016-01-01'),
(4, 129, 3, 1, 1, NULL, '2018-01-01'),
(5, 130, 1, 1, 1, 1, '2016-01-01'),
(6, 130, 3, 1, 1, NULL, '2018-01-01'),
(7, 155, 1, 1, 1, 1, '2013-01-01'),
(8, 155, 3, 1, 1, NULL, '2014-01-01'),
(9, 166, 3, NULL, NULL, NULL, NULL),
(10, 166, 10, NULL, NULL, NULL, NULL),
(11, 171, 1, 1, 0, 0, NULL),
(12, 172, 1, 1, 0, 0, NULL),
(13, 173, 1, 1, 0, 0, NULL),
(14, 174, 1, 1, 0, 0, NULL),
(15, 175, 1, 1, 0, 0, NULL),
(16, 176, 1, 1, 0, 0, NULL),
(17, 179, 1, 1, 0, 0, NULL),
(18, 180, 1, 1, 0, 0, NULL),
(19, 181, 1, 1, 0, 0, NULL),
(20, 182, 1, 1, 0, 0, NULL),
(27, 1, 1, 1, 0, 0, NULL),
(28, 1, 3, 1, 0, 0, NULL),
(29, 185, 1, 1, 0, 0, NULL),
(30, 186, 1, 1, 0, 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthaslinkwithmedicalactor`
--

CREATE TABLE `t_patienthaslinkwithmedicalactor` (
  `fkPatient` int(11) NOT NULL,
  `fkMedicalActor` int(11) NOT NULL,
  `patmedactOkToRetrieveFiles` tinyint(1) DEFAULT NULL,
  `patmedactFollowEndDate` date DEFAULT NULL,
  `patmedactIsStillFollowed` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patienthaslinkwithmedicalactor`
--

INSERT INTO `t_patienthaslinkwithmedicalactor` (`fkPatient`, `fkMedicalActor`, `patmedactOkToRetrieveFiles`, `patmedactFollowEndDate`, `patmedactIsStillFollowed`) VALUES
(151, 11, 0, '2015-01-01', 0),
(152, 11, 1, '2015-01-01', 1),
(152, 1, 0, NULL, 0),
(153, 11, 1, '2015-01-01', 1),
(153, 1, 0, NULL, 0),
(154, 11, 1, '2015-01-01', 1),
(154, 1, 0, NULL, 0),
(155, 1, 1, NULL, 1),
(155, 11, 0, '2016-01-01', 0),
(167, 1, 0, NULL, 1);

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthaslinkwithmedicalestablishment`
--

CREATE TABLE `t_patienthaslinkwithmedicalestablishment` (
  `fkPatient` int(11) NOT NULL,
  `fkMedicalEstablishment` int(11) NOT NULL,
  `patmedestComment` varchar(200) DEFAULT NULL,
  `patmedestIsMain` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patienthaslinkwithmedicalestablishment`
--

INSERT INTO `t_patienthaslinkwithmedicalestablishment` (`fkPatient`, `fkMedicalEstablishment`, `patmedestComment`, `patmedestIsMain`) VALUES
(151, 219, 'Doe Hospital', 0),
(151, 220, '0', 0),
(152, 219, 'Doe Hospital', 0),
(152, 220, '0', 0),
(153, 219, 'Doe Hospital', 0),
(153, 220, '0', 0),
(154, 219, 'Doe Hospital', 0),
(154, 220, '0', 0),
(155, 219, 'Doe Hospital', 1),
(155, 220, '0', 0),
(167, 219, '0', 0),
(167, 220, '0', 0);

-- --------------------------------------------------------

--
-- Table structure for table `t_patienthasothermedicalhistory`
--

CREATE TABLE `t_patienthasothermedicalhistory` (
  `idPatientHasOtherMedicalHistory` int(11) NOT NULL,
  `patothmedhistName` varchar(250) NOT NULL,
  `idxPatient` int(11) NOT NULL,
  `idxUser` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_patientjob`
--

CREATE TABLE `t_patientjob` (
  `idPatientJob` int(11) NOT NULL,
  `patjobOccupation` varchar(100) DEFAULT NULL,
  `patjobEmploymentRate` int(11) NOT NULL DEFAULT '0',
  `fkPatientJobTitle` int(11) DEFAULT NULL,
  `patjobDataCreationDate` date DEFAULT NULL,
  `fkContactAsEmploymentOffice` int(11) DEFAULT NULL,
  `fkContactAsEmployer` int(11) NOT NULL,
  `fkPatient` int(11) NOT NULL,
  `fkPatientJobStatus` int(11) DEFAULT NULL,
  `patjobComments` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patientjob`
--

INSERT INTO `t_patientjob` (`idPatientJob`, `patjobOccupation`, `patjobEmploymentRate`, `fkPatientJobTitle`, `patjobDataCreationDate`, `fkContactAsEmploymentOffice`, `fkContactAsEmployer`, `fkPatient`, `fkPatientJobStatus`, `patjobComments`) VALUES
(1, NULL, 94, 1, NULL, NULL, 6, 135, NULL, NULL),
(2, NULL, 28, 2, NULL, NULL, 9, 135, NULL, NULL),
(3, NULL, 23, 3, NULL, NULL, 10, 136, NULL, NULL),
(4, NULL, 23, 4, NULL, NULL, 10, 137, NULL, 'Unemployment Comment'),
(5, NULL, 23, 5, NULL, NULL, 10, 138, NULL, 'Unemployment Comment'),
(6, NULL, 85, 6, NULL, NULL, 6, 155, NULL, NULL),
(7, NULL, 50, NULL, NULL, NULL, 10, 158, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `t_patientjobstatus`
--

CREATE TABLE `t_patientjobstatus` (
  `idPatientJobStatus` int(11) NOT NULL,
  `patjobstaName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_patientjobtitle`
--

CREATE TABLE `t_patientjobtitle` (
  `idPatientJobTitle` int(11) NOT NULL,
  `patjobtitName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patientjobtitle`
--

INSERT INTO `t_patientjobtitle` (`idPatientJobTitle`, `patjobtitName`) VALUES
(1, 'Developer'),
(2, 'Manager'),
(3, 'Retired'),
(4, 'Retired'),
(5, 'Retired'),
(6, 'Developer');

-- --------------------------------------------------------

--
-- Table structure for table `t_patientrelative`
--

CREATE TABLE `t_patientrelative` (
  `idPatientRelative` int(11) NOT NULL,
  `fkPatient` int(11) DEFAULT NULL,
  `fkContactAsRelative` int(11) DEFAULT NULL,
  `fkPatientAsRelative` int(11) DEFAULT NULL,
  `patrellsEmergencyContact` tinyint(1) DEFAULT NULL,
  `fkPatientRelativeType` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patientrelative`
--

INSERT INTO `t_patientrelative` (`idPatientRelative`, `fkPatient`, `fkContactAsRelative`, `fkPatientAsRelative`, `patrellsEmergencyContact`, `fkPatientRelativeType`) VALUES
(1, 1, 162, 1, 1, NULL),
(2, 106, 162, 2, 0, NULL),
(3, 15, 162, 3, 1, NULL),
(4, 1, 163, 1, 1, NULL),
(5, 106, 163, 2, 0, NULL),
(6, 16, 163, NULL, 1, NULL),
(7, 1, 164, 1, 1, NULL),
(8, 106, 164, 2, 0, NULL),
(9, 17, 164, NULL, 1, NULL),
(10, 169, 1, 169, 0, 4),
(11, 169, 18, 169, 1, 5);

-- --------------------------------------------------------

--
-- Table structure for table `t_patientrelativelink`
--

CREATE TABLE `t_patientrelativelink` (
  `idPatientRelativeLink` int(11) NOT NULL,
  `patrellinName` varchar(50) CHARACTER SET latin1 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_patientrelativelink`
--

INSERT INTO `t_patientrelativelink` (`idPatientRelativeLink`, `patrellinName`) VALUES
(1, 'Brother'),
(2, 'Father'),
(3, 'Mother'),
(4, 'Son-in-law'),
(5, 'Mother-in-law');

-- --------------------------------------------------------

--
-- Table structure for table `t_patientworksforemployer`
--

CREATE TABLE `t_patientworksforemployer` (
  `idPatient` int(6) NOT NULL,
  `idEmployer` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_pharmacies`
--

CREATE TABLE `t_pharmacies` (
  `idPharmacies` int(4) NOT NULL,
  `phaName` varchar(50) NOT NULL,
  `phaCity` int(4) NOT NULL,
  `phaMainPhone` int(15) NOT NULL,
  `phaPhoto` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_pharmacies`
--

INSERT INTO `t_pharmacies` (`idPharmacies`, `phaName`, `phaCity`, `phaMainPhone`, `phaPhoto`) VALUES
(1, 'Pharmacie 24', 13, 2147483647, ''),
(2, 'Amavita Acacias', 6, 2147483647, ''),
(3, 'Amavita Cardinaux', 4, 2147483647, ''),
(4, 'Amavita Jura', 17, 2147483647, ''),
(5, 'Champs Frechets', 14, 2147483647, ''),
(6, 'Pharmacie Cina', 15, 2147483647, ''),
(7, 'Pharmacie D\'Herborence', 16, 2147483647, ''),
(8, 'Pharmacie d\'Orsières', 7, 2147483647, ''),
(9, 'Pharmacie de Clarens', 17, 2147483647, ''),
(10, 'Pharmacie de Cortot', 7, 2147483647, ''),
(11, 'Pharmacie de Florissant - Renens', 14, 2147483647, ''),
(12, 'Pharmacie de l\'ile à Rolle', 11, 2147483647, ''),
(13, 'Pharmacie du Tilleul', 18, 2147483647, ''),
(14, 'Pharmacie Saint-Léger', 9, 2147483647, ''),
(15, 'Pharmacie Populaire - Officine : Varembe', 14, 2147483647, ''),
(16, 'Pharmacie Populaire - Officine : Trois-Chêne', 2, 2147483647, ''),
(17, 'Pharmacie Chablais-Gare', 5, 2147483647, ''),
(18, 'Salveo', 10, 2147483647, ''),
(19, 'Pharmapro', 9, 2147483647, ''),
(20, 'Pharmacies de Garde à Martigny', 9, 2147483647, '');

-- --------------------------------------------------------

--
-- Table structure for table `t_pharmaciesbelongtoappointment`
--

CREATE TABLE `t_pharmaciesbelongtoappointment` (
  `id` int(11) NOT NULL,
  `idAppointment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_poste`
--

CREATE TABLE `t_poste` (
  `idPoste` int(11) NOT NULL,
  `posName` varchar(255) NOT NULL,
  `posImage` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_poste`
--

INSERT INTO `t_poste` (`idPoste`, `posName`, `posImage`) VALUES
(1, 'Medecin', 'img/woman-2.png'),
(2, 'Assistante', 'img/woman-2.png'),
(3, 'Technicien', 'img/company-4.png');

-- --------------------------------------------------------

--
-- Table structure for table `t_task`
--

CREATE TABLE `t_task` (
  `idTask` int(11) NOT NULL,
  `tasTitle` varchar(255) NOT NULL,
  `tasDescription` varchar(255) NOT NULL,
  `tasCreateDate` date NOT NULL,
  `tasCreateTime` time NOT NULL,
  `tasExecuteDate` date NOT NULL,
  `tasExecuteTime` time NOT NULL,
  `fkCreateUser` int(11) NOT NULL,
  `idTaskState` int(11) NOT NULL,
  `idTaskCategory` int(11) NOT NULL,
  `idPriority` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_task`
--

INSERT INTO `t_task` (`idTask`, `tasTitle`, `tasDescription`, `tasCreateDate`, `tasCreateTime`, `tasExecuteDate`, `tasExecuteTime`, `fkCreateUser`, `idTaskState`, `idTaskCategory`, `idPriority`) VALUES
(1, 'Verifier Mise en poursuite', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:33', '2018-12-12', '15:00:00', 3, 2, 3, 3),
(2, 'Répondre au mail de confrères', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:43', '2018-12-12', '15:00:00', 2, 2, 5, 2),
(3, 'Mettre à jour coordonnée', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:12', '2018-12-12', '15:00:00', 3, 4, 6, 3),
(4, 'vérifier rdv', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:15', '2018-12-12', '15:00:00', 3, 3, 7, 3),
(5, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-12', '15:00:00', 3, 1, 9, 4),
(6, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-13', '15:00:00', 1, 1, 8, 2),
(7, 'Verifier Mise en poursuite', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:33', '2018-12-18', '15:40:00', 1, 1, 9, 4),
(8, 'Répondre au mail de confrères', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:43', '2018-12-12', '15:00:00', 1, 3, 5, 4),
(9, 'Mettre à jour coordonnée', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:12', '2018-12-12', '15:00:00', 3, 2, 6, 3),
(10, 'vérifier rdv', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:15', '2018-12-12', '15:00:00', 1, 4, 7, 1),
(11, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-12', '15:00:00', 3, 4, 9, 2),
(12, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-13', '15:00:00', 2, 4, 8, 3),
(13, 'Verifier Mise en poursuite', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:33', '2018-12-18', '15:40:00', 3, 1, 9, 2),
(14, 'Répondre au mail de confrères', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:43', '2018-12-12', '15:00:00', 2, 2, 5, 4),
(15, 'Mettre à jour coordonnée', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:12', '2018-12-12', '15:00:00', 1, 2, 6, 2),
(16, 'vérifier rdv', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:15', '2018-12-12', '15:00:00', 1, 2, 7, 1),
(17, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-12', '15:00:00', 2, 3, 9, 4),
(18, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-13', '15:00:00', 3, 1, 8, 4),
(19, 'Verifier Mise en poursuite', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:33', '2018-12-18', '15:40:00', 2, 4, 9, 3),
(20, 'Répondre au mail de confrères', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:43', '2018-12-12', '15:00:00', 1, 1, 5, 4),
(21, 'Mettre à jour coordonnée', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:12', '2018-12-12', '15:00:00', 3, 2, 6, 2),
(22, 'vérifier rdv', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:15', '2018-12-12', '15:00:00', 1, 4, 7, 2),
(23, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-12', '15:00:00', 2, 4, 9, 4),
(24, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-13', '15:00:00', 2, 2, 8, 2),
(25, 'Verifier Mise en poursuite', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:33', '2018-12-18', '15:40:00', 1, 3, 9, 4),
(26, 'Répondre au mail de confrères', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:43', '2018-12-12', '15:00:00', 3, 1, 5, 2),
(27, 'Mettre à jour coordonnée', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:12', '2018-12-12', '15:00:00', 2, 2, 6, 3),
(28, 'vérifier rdv', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:15', '2018-12-12', '15:00:00', 1, 1, 7, 4),
(29, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-12', '15:00:00', 2, 4, 9, 3),
(30, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-13', '15:00:00', 1, 1, 8, 1),
(31, 'Verifier Mise en poursuite', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:33', '2018-12-18', '15:40:00', 2, 3, 9, 1),
(32, 'Répondre au mail de confrères', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:43:43', '2018-12-12', '15:00:00', 3, 4, 5, 3),
(33, 'Mettre à jour coordonnée', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:12', '2018-12-12', '15:00:00', 3, 4, 6, 4),
(34, 'vérifier rdv', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:15', '2018-12-12', '15:00:00', 3, 3, 7, 2),
(35, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-12', '15:00:00', 2, 4, 9, 4),
(36, 'Consulter le suivis', 'Remettre l\'ordonnance du patient', '2018-12-11', '15:44:57', '2018-12-13', '15:00:00', 2, 4, 8, 4);

-- --------------------------------------------------------

--
-- Table structure for table `t_taskcategory`
--

CREATE TABLE `t_taskcategory` (
  `idTaskCategory` int(11) NOT NULL,
  `tasTitle` varchar(255) NOT NULL,
  `tasColor` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_taskcategory`
--

INSERT INTO `t_taskcategory` (`idTaskCategory`, `tasTitle`, `tasColor`) VALUES
(3, 'Facturation', 'billing'),
(5, 'Médical', 'medical'),
(6, 'patient', 'patient'),
(7, 'Agenda', 'agenda'),
(8, 'Gestionnaire de Tâches', 'task-manager'),
(9, 'Administration', 'dashboard');

-- --------------------------------------------------------

--
-- Table structure for table `t_taskmessage`
--

CREATE TABLE `t_taskmessage` (
  `idTaskMessage` int(11) NOT NULL,
  `tasMessage` varchar(255) NOT NULL,
  `tasMessageDate` date NOT NULL,
  `tasMessageHour` time NOT NULL,
  `fkUser` int(11) NOT NULL,
  `idTask` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_taskpriority`
--

CREATE TABLE `t_taskpriority` (
  `idPriority` int(11) NOT NULL,
  `priTitle` varchar(255) NOT NULL,
  `priLevel` int(11) NOT NULL,
  `priColor` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_taskpriority`
--

INSERT INTO `t_taskpriority` (`idPriority`, `priTitle`, `priLevel`, `priColor`) VALUES
(1, 'Urgent', 1, '--urgent'),
(2, 'Haut', 2, '--top'),
(3, 'Normal', 3, 'null'),
(4, 'Bas', 4, '--bas');

-- --------------------------------------------------------

--
-- Table structure for table `t_taskstate`
--

CREATE TABLE `t_taskstate` (
  `idTaskState` int(11) NOT NULL,
  `tasTitle` varchar(255) NOT NULL,
  `tasState` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_taskstate`
--

INSERT INTO `t_taskstate` (`idTaskState`, `tasTitle`, `tasState`) VALUES
(1, 'En cours', 2),
(2, 'Non traité', 1),
(3, 'En attente', 3),
(4, 'Terminé', 4);

-- --------------------------------------------------------

--
-- Table structure for table `t_taskstep`
--

CREATE TABLE `t_taskstep` (
  `idStep` int(11) NOT NULL,
  `steTitle` varchar(255) NOT NULL,
  `steDescription` varchar(255) NOT NULL,
  `steDoneStepDate` date DEFAULT NULL,
  `steDoneStepTime` time DEFAULT NULL,
  `fkUser` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_timespan`
--

CREATE TABLE `t_timespan` (
  `idTimeSpan` int(11) NOT NULL,
  `timName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `t_user`
--

CREATE TABLE `t_user` (
  `idUser` int(11) NOT NULL,
  `useUsername` varchar(255) NOT NULL,
  `useName` varchar(255) NOT NULL,
  `useFirstName` varchar(255) NOT NULL,
  `useMailAdress` varchar(255) NOT NULL,
  `usePassword` varchar(255) NOT NULL,
  `useImageLink` varchar(255) NOT NULL,
  `idPoste` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_user`
--

INSERT INTO `t_user` (`idUser`, `useUsername`, `useName`, `useFirstName`, `useMailAdress`, `usePassword`, `useImageLink`, `idPoste`) VALUES
(1, 'GiTardieu', 'Tardieu', 'Gilles', 'gilles.tardieu@hotmail.com', '1234', 'img/man-1.png', 1),
(2, 'AnFasano', 'Fasano', 'Anthony', 'a.fasano@docteur.com', '1234', 'img/woman-2.png', 2),
(3, 'GrKrieger', 'Krieger', 'Grégory', 'g.krieger2docteur.com', '1234', 'img/man-2.png', 3);

-- --------------------------------------------------------

--
-- Table structure for table `t_userbelongtoestablishment`
--

CREATE TABLE `t_userbelongtoestablishment` (
  `fkUser` int(11) NOT NULL,
  `fkEstablishment` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_userbelongtoestablishment`
--

INSERT INTO `t_userbelongtoestablishment` (`fkUser`, `fkEstablishment`) VALUES
(1, 1),
(2, 1),
(3, 2),
(2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `t_userbelongtotask`
--

CREATE TABLE `t_userbelongtotask` (
  `fkUser` int(11) NOT NULL,
  `fkTask` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `t_userbelongtotask`
--

INSERT INTO `t_userbelongtotask` (`fkUser`, `fkTask`) VALUES
(1, 1),
(2, 3),
(3, 5),
(2, 2),
(2, 4),
(1, 6),
(2, 6),
(1, 6),
(2, 7),
(3, 8),
(1, 9),
(2, 10),
(3, 11),
(1, 12),
(1, 13),
(1, 14),
(2, 15),
(3, 16),
(3, 17),
(2, 18),
(1, 19),
(1, 20),
(2, 21),
(3, 22),
(2, 23),
(1, 24),
(1, 25),
(3, 26),
(2, 27),
(1, 28),
(2, 29),
(1, 30),
(2, 31),
(2, 32),
(1, 33),
(3, 34),
(1, 35),
(2, 36);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `t_address`
--
ALTER TABLE `t_address`
  ADD PRIMARY KEY (`idAddress`);

--
-- Indexes for table `t_addressbelongtocontact`
--
ALTER TABLE `t_addressbelongtocontact`
  ADD UNIQUE KEY `fkAddress` (`fkAddress`),
  ADD UNIQUE KEY `fkContact` (`fkContact`);

--
-- Indexes for table `t_addressbelongtomedicalestablishment`
--
ALTER TABLE `t_addressbelongtomedicalestablishment`
  ADD PRIMARY KEY (`idxAddress`);

--
-- Indexes for table `t_addressbelongtopatient`
--
ALTER TABLE `t_addressbelongtopatient`
  ADD PRIMARY KEY (`idxAddress`,`idxPatient`);

--
-- Indexes for table `t_addresstype`
--
ALTER TABLE `t_addresstype`
  ADD PRIMARY KEY (`idAddressType`);

--
-- Indexes for table `t_allergy`
--
ALTER TABLE `t_allergy`
  ADD PRIMARY KEY (`idAllergy`);

--
-- Indexes for table `t_anamnesysandsymptoms`
--
ALTER TABLE `t_anamnesysandsymptoms`
  ADD PRIMARY KEY (`idAnamnesysandsymptoms`);

--
-- Indexes for table `t_anamnesysandsymptomsbelongtoconsultations`
--
ALTER TABLE `t_anamnesysandsymptomsbelongtoconsultations`
  ADD KEY `fkAnamnesysandsymptoms` (`fkAnamnesysandsymptoms`),
  ADD KEY `fkConsultations` (`fkConsultations`);

--
-- Indexes for table `t_appointment`
--
ALTER TABLE `t_appointment`
  ADD PRIMARY KEY (`idAppointment`),
  ADD KEY `appType` (`appType`);

--
-- Indexes for table `t_appointmenttype`
--
ALTER TABLE `t_appointmenttype`
  ADD PRIMARY KEY (`idAppointmentType`);

--
-- Indexes for table `t_bankaccount`
--
ALTER TABLE `t_bankaccount`
  ADD PRIMARY KEY (`idBankAccount`);

--
-- Indexes for table `t_belontoprescription`
--
ALTER TABLE `t_belontoprescription`
  ADD PRIMARY KEY (`idMedicament`,`idMedicalPrescription`),
  ADD KEY `t_belonToPrescription_t_medicalPrescription0_FK` (`idMedicalPrescription`);

--
-- Indexes for table `t_calendar`
--
ALTER TABLE `t_calendar`
  ADD PRIMARY KEY (`idCalendar`),
  ADD KEY `t_calendar_fkUser_FK` (`fkUser`);

--
-- Indexes for table `t_chronicdisease`
--
ALTER TABLE `t_chronicdisease`
  ADD PRIMARY KEY (`idChronicDisease`);

--
-- Indexes for table `t_cities`
--
ALTER TABLE `t_cities`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `t_clinicalsigns`
--
ALTER TABLE `t_clinicalsigns`
  ADD PRIMARY KEY (`idClinicalsigns`);

--
-- Indexes for table `t_clinicalsignsbelongtoconsultations`
--
ALTER TABLE `t_clinicalsignsbelongtoconsultations`
  ADD KEY `fkClinicalsigns` (`fkClinicalsigns`),
  ADD KEY `fkConsultations` (`fkConsultations`);

--
-- Indexes for table `t_cliniquebelongtoappointment`
--
ALTER TABLE `t_cliniquebelongtoappointment`
  ADD PRIMARY KEY (`id`,`idAppointment`,`idAppointment_t_appointment`),
  ADD UNIQUE KEY `id` (`id`),
  ADD KEY `t_cliniquebelongtoappointment_t_appointment0_FK` (`idAppointment`),
  ADD KEY `t_cliniquebelongtoappointment_t_appointment1_FK` (`idAppointment_t_appointment`);

--
-- Indexes for table `t_cliniques`
--
ALTER TABLE `t_cliniques`
  ADD PRIMARY KEY (`idCliniques`),
  ADD KEY `city` (`cliCity`);

--
-- Indexes for table `t_config`
--
ALTER TABLE `t_config`
  ADD PRIMARY KEY (`idConfig`);

--
-- Indexes for table `t_consultations`
--
ALTER TABLE `t_consultations`
  ADD PRIMARY KEY (`idConsultations`),
  ADD KEY `t_consultations_ibfk_1` (`idAppointment`),
  ADD KEY `idPatients` (`idPatient`);

--
-- Indexes for table `t_contact`
--
ALTER TABLE `t_contact`
  ADD PRIMARY KEY (`idContact`);

--
-- Indexes for table `t_contacthastype`
--
ALTER TABLE `t_contacthastype`
  ADD UNIQUE KEY `fkContact` (`fkContact`);

--
-- Indexes for table `t_contacttype`
--
ALTER TABLE `t_contacttype`
  ADD PRIMARY KEY (`idContactType`);

--
-- Indexes for table `t_country`
--
ALTER TABLE `t_country`
  ADD PRIMARY KEY (`idCountry`);

--
-- Indexes for table `t_diagnostics`
--
ALTER TABLE `t_diagnostics`
  ADD PRIMARY KEY (`idDiagnostics`);

--
-- Indexes for table `t_diagnosticsbelongtoconsultations`
--
ALTER TABLE `t_diagnosticsbelongtoconsultations`
  ADD KEY `fkConsultations` (`fkConsultations`),
  ADD KEY `fkDiagnostics` (`fkDiagnostics`);

--
-- Indexes for table `t_dispatchandinsurance`
--
ALTER TABLE `t_dispatchandinsurance`
  ADD PRIMARY KEY (`idDispatchAndInsurance`);

--
-- Indexes for table `t_documentbelongtotask`
--
ALTER TABLE `t_documentbelongtotask`
  ADD KEY `t_documentBelongToTask_t_task_FK` (`idTask`);

--
-- Indexes for table `t_drugintolerance`
--
ALTER TABLE `t_drugintolerance`
  ADD PRIMARY KEY (`idDrugIntolerance`);

--
-- Indexes for table `t_employees`
--
ALTER TABLE `t_employees`
  ADD PRIMARY KEY (`idEmployees`),
  ADD KEY `city` (`empCity`);

--
-- Indexes for table `t_employerbelongtoappointment`
--
ALTER TABLE `t_employerbelongtoappointment`
  ADD PRIMARY KEY (`idAppointment`,`id`),
  ADD KEY `t_employerbelongtoappointment_employers0_FK` (`id`);

--
-- Indexes for table `t_employers`
--
ALTER TABLE `t_employers`
  ADD PRIMARY KEY (`idEmployers`);

--
-- Indexes for table `t_establishment`
--
ALTER TABLE `t_establishment`
  ADD PRIMARY KEY (`idEstablishment`);

--
-- Indexes for table `t_establishmentbelongtoconfig`
--
ALTER TABLE `t_establishmentbelongtoconfig`
  ADD KEY `t_establishmentbelongtoconfig_t_establishment_FK` (`fkEstablishment`),
  ADD KEY `t_establishmentbelongtoconfig_t_config_FK` (`fkconfig`);

--
-- Indexes for table `t_familyrelationship`
--
ALTER TABLE `t_familyrelationship`
  ADD PRIMARY KEY (`idFamilyRelationship`);

--
-- Indexes for table `t_hasstep`
--
ALTER TABLE `t_hasstep`
  ADD PRIMARY KEY (`idTask`,`idStep`),
  ADD KEY `t_hasStep_t_taskStep0_FK` (`idStep`);

--
-- Indexes for table `t_infotype`
--
ALTER TABLE `t_infotype`
  ADD PRIMARY KEY (`idInfoType`);

--
-- Indexes for table `t_insurancebelongtoappointment`
--
ALTER TABLE `t_insurancebelongtoappointment`
  ADD PRIMARY KEY (`idAppointment`,`id`),
  ADD KEY `t_insurancebelongtoappointment_insurances0_FK` (`id`);

--
-- Indexes for table `t_insurances`
--
ALTER TABLE `t_insurances`
  ADD PRIMARY KEY (`idInsurances`),
  ADD KEY `city` (`insCity`);

--
-- Indexes for table `t_invoice`
--
ALTER TABLE `t_invoice`
  ADD PRIMARY KEY (`idInvoice`),
  ADD KEY `t_invoice_fkInvoiceStatus_FK` (`fkInvoiceStatus`),
  ADD KEY `t_invoice_fkBankAccount_FK` (`fkBankAccount`),
  ADD KEY `t_invoice_fkDispatchAndInsurance_FK` (`fkDispatchAndInsurance`),
  ADD KEY `t_invoice_fkMedicalEstablishment_FK` (`fkMedicalEstablishment`),
  ADD KEY `t_invoice_fkPatient_FK` (`fkPatient`),
  ADD KEY `t_invoice_fkMedicalActor_FK` (`fkMedicalActor`);

--
-- Indexes for table `t_invoicestatus`
--
ALTER TABLE `t_invoicestatus`
  ADD PRIMARY KEY (`idInvoiceStatus`);

--
-- Indexes for table `t_licenseestablishment`
--
ALTER TABLE `t_licenseestablishment`
  ADD PRIMARY KEY (`idLicenseEstablishment`);

--
-- Indexes for table `t_log`
--
ALTER TABLE `t_log`
  ADD PRIMARY KEY (`idLog`);

--
-- Indexes for table `t_medicalactor`
--
ALTER TABLE `t_medicalactor`
  ADD PRIMARY KEY (`idMedicalActor`);

--
-- Indexes for table `t_medicalactorhaslinkwithpatient`
--
ALTER TABLE `t_medicalactorhaslinkwithpatient`
  ADD PRIMARY KEY (`idxMedicalActor`,`idxPatient`);

--
-- Indexes for table `t_medicalactorspecialization`
--
ALTER TABLE `t_medicalactorspecialization`
  ADD PRIMARY KEY (`idMedicalActorSpecialization`);

--
-- Indexes for table `t_medicalactortitle`
--
ALTER TABLE `t_medicalactortitle`
  ADD PRIMARY KEY (`idMedicalActorTitle`);

--
-- Indexes for table `t_medicalestablishment`
--
ALTER TABLE `t_medicalestablishment`
  ADD PRIMARY KEY (`idMedicalEstablishment`);

--
-- Indexes for table `t_medicalestablishmenthaslinkwithpatient`
--
ALTER TABLE `t_medicalestablishmenthaslinkwithpatient`
  ADD PRIMARY KEY (`idxMedicalEstablishment`,`idxPatient`);

--
-- Indexes for table `t_medicalestablishmenthastype`
--
ALTER TABLE `t_medicalestablishmenthastype`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fkMedicalEstablishmentType` (`fkMedicalEstablishmentType`),
  ADD KEY `fkMedicalEstablishment` (`fkMedicalEstablishment`);

--
-- Indexes for table `t_medicalestablishmenttype`
--
ALTER TABLE `t_medicalestablishmenttype`
  ADD PRIMARY KEY (`idMedicalEstablishmentType`);

--
-- Indexes for table `t_medicalprescription`
--
ALTER TABLE `t_medicalprescription`
  ADD PRIMARY KEY (`idMedicalPrescription`),
  ADD KEY `fkConsultations` (`fkConsultations`),
  ADD KEY `fkMedicament` (`fkMedicament`),
  ADD KEY `fkPatients` (`fkPatients`);

--
-- Indexes for table `t_medicament`
--
ALTER TABLE `t_medicament`
  ADD PRIMARY KEY (`idMedicament`);

--
-- Indexes for table `t_otherhealthcare`
--
ALTER TABLE `t_otherhealthcare`
  ADD PRIMARY KEY (`idOtherhealthcare`),
  ADD KEY `city` (`othCity`);

--
-- Indexes for table `t_otherhealthcarebelongtoappointment`
--
ALTER TABLE `t_otherhealthcarebelongtoappointment`
  ADD PRIMARY KEY (`idAppointment`,`id`),
  ADD KEY `t_otherhealthcarebelongtoappointment_other_healthcare0_FK` (`id`);

--
-- Indexes for table `t_othermedicalhistory`
--
ALTER TABLE `t_othermedicalhistory`
  ADD PRIMARY KEY (`idOtherMedicalHistory`);

--
-- Indexes for table `t_patient`
--
ALTER TABLE `t_patient`
  ADD PRIMARY KEY (`idPatient`);

--
-- Indexes for table `t_patientbelongtoappointment`
--
ALTER TABLE `t_patientbelongtoappointment`
  ADD PRIMARY KEY (`id`,`idAppointment`),
  ADD KEY `t_patientbelongtoappointment_t_appointment0_FK` (`idAppointment`);

--
-- Indexes for table `t_patienthasallergy`
--
ALTER TABLE `t_patienthasallergy`
  ADD PRIMARY KEY (`idxAllergy`,`idxPatient`);

--
-- Indexes for table `t_patienthaschronicdisease`
--
ALTER TABLE `t_patienthaschronicdisease`
  ADD PRIMARY KEY (`idxChronicDisease`,`idxPatient`);

--
-- Indexes for table `t_patienthasdrugintolerance`
--
ALTER TABLE `t_patienthasdrugintolerance`
  ADD PRIMARY KEY (`idxDrugIntolerance`,`idxPatient`);

--
-- Indexes for table `t_patienthasinsurance`
--
ALTER TABLE `t_patienthasinsurance`
  ADD PRIMARY KEY (`patHasInsId`);

--
-- Indexes for table `t_patienthasothermedicalhistory`
--
ALTER TABLE `t_patienthasothermedicalhistory`
  ADD PRIMARY KEY (`idPatientHasOtherMedicalHistory`);

--
-- Indexes for table `t_patientjob`
--
ALTER TABLE `t_patientjob`
  ADD PRIMARY KEY (`idPatientJob`);

--
-- Indexes for table `t_patientjobstatus`
--
ALTER TABLE `t_patientjobstatus`
  ADD PRIMARY KEY (`idPatientJobStatus`);

--
-- Indexes for table `t_patientjobtitle`
--
ALTER TABLE `t_patientjobtitle`
  ADD PRIMARY KEY (`idPatientJobTitle`);

--
-- Indexes for table `t_patientrelative`
--
ALTER TABLE `t_patientrelative`
  ADD PRIMARY KEY (`idPatientRelative`);

--
-- Indexes for table `t_patientrelativelink`
--
ALTER TABLE `t_patientrelativelink`
  ADD PRIMARY KEY (`idPatientRelativeLink`);

--
-- Indexes for table `t_patientworksforemployer`
--
ALTER TABLE `t_patientworksforemployer`
  ADD KEY `t_patientworksforemployer_ibfk_1` (`idPatient`),
  ADD KEY `idEmployer` (`idEmployer`);

--
-- Indexes for table `t_pharmacies`
--
ALTER TABLE `t_pharmacies`
  ADD PRIMARY KEY (`idPharmacies`),
  ADD KEY `city` (`phaCity`);

--
-- Indexes for table `t_pharmaciesbelongtoappointment`
--
ALTER TABLE `t_pharmaciesbelongtoappointment`
  ADD PRIMARY KEY (`id`,`idAppointment`),
  ADD KEY `t_pharmaciesbelongtoappointment_t_appointment0_FK` (`idAppointment`);

--
-- Indexes for table `t_poste`
--
ALTER TABLE `t_poste`
  ADD PRIMARY KEY (`idPoste`);

--
-- Indexes for table `t_task`
--
ALTER TABLE `t_task`
  ADD PRIMARY KEY (`idTask`),
  ADD KEY `t_task_t_taskstate_FK` (`idTaskState`),
  ADD KEY `t_task_t_taskcategory0_FK` (`idTaskCategory`),
  ADD KEY `t_task_t_taskPriority1_FK` (`idPriority`);

--
-- Indexes for table `t_taskcategory`
--
ALTER TABLE `t_taskcategory`
  ADD PRIMARY KEY (`idTaskCategory`);

--
-- Indexes for table `t_taskmessage`
--
ALTER TABLE `t_taskmessage`
  ADD PRIMARY KEY (`idTaskMessage`),
  ADD KEY `t_taskMessage_t_task_FK` (`idTask`);

--
-- Indexes for table `t_taskpriority`
--
ALTER TABLE `t_taskpriority`
  ADD PRIMARY KEY (`idPriority`);

--
-- Indexes for table `t_taskstate`
--
ALTER TABLE `t_taskstate`
  ADD PRIMARY KEY (`idTaskState`);

--
-- Indexes for table `t_taskstep`
--
ALTER TABLE `t_taskstep`
  ADD PRIMARY KEY (`idStep`);

--
-- Indexes for table `t_timespan`
--
ALTER TABLE `t_timespan`
  ADD PRIMARY KEY (`idTimeSpan`);

--
-- Indexes for table `t_user`
--
ALTER TABLE `t_user`
  ADD PRIMARY KEY (`idUser`),
  ADD KEY `t_user_t_poste_FK` (`idPoste`);

--
-- Indexes for table `t_userbelongtoestablishment`
--
ALTER TABLE `t_userbelongtoestablishment`
  ADD KEY `t_userbelongtoestablishment_t_user_FK` (`fkUser`),
  ADD KEY `t_userbelongtoestablishment_t_establishment_FK` (`fkEstablishment`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `t_address`
--
ALTER TABLE `t_address`
  MODIFY `idAddress` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=531;
--
-- AUTO_INCREMENT for table `t_addressbelongtomedicalestablishment`
--
ALTER TABLE `t_addressbelongtomedicalestablishment`
  MODIFY `idxAddress` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=452;
--
-- AUTO_INCREMENT for table `t_addresstype`
--
ALTER TABLE `t_addresstype`
  MODIFY `idAddressType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `t_allergy`
--
ALTER TABLE `t_allergy`
  MODIFY `idAllergy` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `t_anamnesysandsymptoms`
--
ALTER TABLE `t_anamnesysandsymptoms`
  MODIFY `idAnamnesysandsymptoms` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `t_appointment`
--
ALTER TABLE `t_appointment`
  MODIFY `idAppointment` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=455;
--
-- AUTO_INCREMENT for table `t_appointmenttype`
--
ALTER TABLE `t_appointmenttype`
  MODIFY `idAppointmentType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_bankaccount`
--
ALTER TABLE `t_bankaccount`
  MODIFY `idBankAccount` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `t_calendar`
--
ALTER TABLE `t_calendar`
  MODIFY `idCalendar` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_chronicdisease`
--
ALTER TABLE `t_chronicdisease`
  MODIFY `idChronicDisease` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `t_cities`
--
ALTER TABLE `t_cities`
  MODIFY `id` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `t_clinicalsigns`
--
ALTER TABLE `t_clinicalsigns`
  MODIFY `idClinicalsigns` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `t_cliniques`
--
ALTER TABLE `t_cliniques`
  MODIFY `idCliniques` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT for table `t_config`
--
ALTER TABLE `t_config`
  MODIFY `idConfig` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `t_consultations`
--
ALTER TABLE `t_consultations`
  MODIFY `idConsultations` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=44;
--
-- AUTO_INCREMENT for table `t_contact`
--
ALTER TABLE `t_contact`
  MODIFY `idContact` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `t_contacttype`
--
ALTER TABLE `t_contacttype`
  MODIFY `idContactType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_country`
--
ALTER TABLE `t_country`
  MODIFY `idCountry` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `t_diagnostics`
--
ALTER TABLE `t_diagnostics`
  MODIFY `idDiagnostics` int(6) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_dispatchandinsurance`
--
ALTER TABLE `t_dispatchandinsurance`
  MODIFY `idDispatchAndInsurance` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `t_drugintolerance`
--
ALTER TABLE `t_drugintolerance`
  MODIFY `idDrugIntolerance` smallint(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `t_employees`
--
ALTER TABLE `t_employees`
  MODIFY `idEmployees` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=121;
--
-- AUTO_INCREMENT for table `t_employers`
--
ALTER TABLE `t_employers`
  MODIFY `idEmployers` int(6) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_establishment`
--
ALTER TABLE `t_establishment`
  MODIFY `idEstablishment` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `t_familyrelationship`
--
ALTER TABLE `t_familyrelationship`
  MODIFY `idFamilyRelationship` int(6) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_infotype`
--
ALTER TABLE `t_infotype`
  MODIFY `idInfoType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_insurances`
--
ALTER TABLE `t_insurances`
  MODIFY `idInsurances` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `t_invoice`
--
ALTER TABLE `t_invoice`
  MODIFY `idInvoice` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
--
-- AUTO_INCREMENT for table `t_invoicestatus`
--
ALTER TABLE `t_invoicestatus`
  MODIFY `idInvoiceStatus` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `t_licenseestablishment`
--
ALTER TABLE `t_licenseestablishment`
  MODIFY `idLicenseEstablishment` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `t_log`
--
ALTER TABLE `t_log`
  MODIFY `idLog` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=104;
--
-- AUTO_INCREMENT for table `t_medicalactor`
--
ALTER TABLE `t_medicalactor`
  MODIFY `idMedicalActor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `t_medicalactorspecialization`
--
ALTER TABLE `t_medicalactorspecialization`
  MODIFY `idMedicalActorSpecialization` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_medicalactortitle`
--
ALTER TABLE `t_medicalactortitle`
  MODIFY `idMedicalActorTitle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `t_medicalestablishment`
--
ALTER TABLE `t_medicalestablishment`
  MODIFY `idMedicalEstablishment` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=221;
--
-- AUTO_INCREMENT for table `t_medicalestablishmenthastype`
--
ALTER TABLE `t_medicalestablishmenthastype`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `t_medicalestablishmenttype`
--
ALTER TABLE `t_medicalestablishmenttype`
  MODIFY `idMedicalEstablishmentType` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=50;
--
-- AUTO_INCREMENT for table `t_medicalprescription`
--
ALTER TABLE `t_medicalprescription`
  MODIFY `idMedicalPrescription` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `t_medicament`
--
ALTER TABLE `t_medicament`
  MODIFY `idMedicament` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `t_othermedicalhistory`
--
ALTER TABLE `t_othermedicalhistory`
  MODIFY `idOtherMedicalHistory` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `t_patient`
--
ALTER TABLE `t_patient`
  MODIFY `idPatient` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=187;
--
-- AUTO_INCREMENT for table `t_patienthasinsurance`
--
ALTER TABLE `t_patienthasinsurance`
  MODIFY `patHasInsId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT for table `t_patienthasothermedicalhistory`
--
ALTER TABLE `t_patienthasothermedicalhistory`
  MODIFY `idPatientHasOtherMedicalHistory` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_patientjob`
--
ALTER TABLE `t_patientjob`
  MODIFY `idPatientJob` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `t_patientjobstatus`
--
ALTER TABLE `t_patientjobstatus`
  MODIFY `idPatientJobStatus` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_patientjobtitle`
--
ALTER TABLE `t_patientjobtitle`
  MODIFY `idPatientJobTitle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `t_patientrelative`
--
ALTER TABLE `t_patientrelative`
  MODIFY `idPatientRelative` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `t_patientrelativelink`
--
ALTER TABLE `t_patientrelativelink`
  MODIFY `idPatientRelativeLink` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `t_pharmacies`
--
ALTER TABLE `t_pharmacies`
  MODIFY `idPharmacies` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
--
-- AUTO_INCREMENT for table `t_poste`
--
ALTER TABLE `t_poste`
  MODIFY `idPoste` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `t_task`
--
ALTER TABLE `t_task`
  MODIFY `idTask` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=37;
--
-- AUTO_INCREMENT for table `t_taskcategory`
--
ALTER TABLE `t_taskcategory`
  MODIFY `idTaskCategory` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `t_taskmessage`
--
ALTER TABLE `t_taskmessage`
  MODIFY `idTaskMessage` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_taskpriority`
--
ALTER TABLE `t_taskpriority`
  MODIFY `idPriority` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_taskstate`
--
ALTER TABLE `t_taskstate`
  MODIFY `idTaskState` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `t_taskstep`
--
ALTER TABLE `t_taskstep`
  MODIFY `idStep` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_timespan`
--
ALTER TABLE `t_timespan`
  MODIFY `idTimeSpan` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `t_user`
--
ALTER TABLE `t_user`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `t_addressbelongtocontact`
--
ALTER TABLE `t_addressbelongtocontact`
  ADD CONSTRAINT `fkAddress` FOREIGN KEY (`fkAddress`) REFERENCES `t_address` (`idAddress`),
  ADD CONSTRAINT `fkContactId` FOREIGN KEY (`fkContact`) REFERENCES `t_contact` (`idContact`);

--
-- Constraints for table `t_anamnesysandsymptomsbelongtoconsultations`
--
ALTER TABLE `t_anamnesysandsymptomsbelongtoconsultations`
  ADD CONSTRAINT `t_anamnesysandsymptomsbelongtoconsultations_ibfk_1` FOREIGN KEY (`fkAnamnesysandsymptoms`) REFERENCES `t_anamnesysandsymptoms` (`idAnamnesysandsymptoms`),
  ADD CONSTRAINT `t_anamnesysandsymptomsbelongtoconsultations_ibfk_2` FOREIGN KEY (`fkConsultations`) REFERENCES `t_consultations` (`idConsultations`);

--
-- Constraints for table `t_appointment`
--
ALTER TABLE `t_appointment`
  ADD CONSTRAINT `t_appointment_ibfk_1` FOREIGN KEY (`appType`) REFERENCES `t_appointmenttype` (`idAppointmentType`);

--
-- Constraints for table `t_belontoprescription`
--
ALTER TABLE `t_belontoprescription`
  ADD CONSTRAINT `t_belonToPrescription_t_medicalPrescription0_FK` FOREIGN KEY (`idMedicalPrescription`) REFERENCES `t_medicalprescription` (`idMedicalPrescription`),
  ADD CONSTRAINT `t_belonToPrescription_t_medicament_FK` FOREIGN KEY (`idMedicament`) REFERENCES `t_medicament` (`idMedicament`);

--
-- Constraints for table `t_clinicalsignsbelongtoconsultations`
--
ALTER TABLE `t_clinicalsignsbelongtoconsultations`
  ADD CONSTRAINT `t_clinicalsignsbelongtoconsultations_ibfk_1` FOREIGN KEY (`fkClinicalsigns`) REFERENCES `t_clinicalsigns` (`idClinicalsigns`),
  ADD CONSTRAINT `t_clinicalsignsbelongtoconsultations_ibfk_2` FOREIGN KEY (`fkConsultations`) REFERENCES `t_consultations` (`idConsultations`);

--
-- Constraints for table `t_cliniquebelongtoappointment`
--
ALTER TABLE `t_cliniquebelongtoappointment`
  ADD CONSTRAINT `t_cliniquebelongtoappointment_cliniques_FK` FOREIGN KEY (`id`) REFERENCES `t_cliniques` (`idCliniques`),
  ADD CONSTRAINT `t_cliniquebelongtoappointment_t_appointment0_FK` FOREIGN KEY (`idAppointment`) REFERENCES `t_appointment` (`idAppointment`),
  ADD CONSTRAINT `t_cliniquebelongtoappointment_t_appointment1_FK` FOREIGN KEY (`idAppointment_t_appointment`) REFERENCES `t_appointment` (`idAppointment`);

--
-- Constraints for table `t_cliniques`
--
ALTER TABLE `t_cliniques`
  ADD CONSTRAINT `t_cliniques_ibfk_1` FOREIGN KEY (`cliCity`) REFERENCES `t_cities` (`id`);

--
-- Constraints for table `t_consultations`
--
ALTER TABLE `t_consultations`
  ADD CONSTRAINT `t_consultations_ibfk_1` FOREIGN KEY (`idAppointment`) REFERENCES `t_appointment` (`idAppointment`),
  ADD CONSTRAINT `t_consultations_ibfk_2` FOREIGN KEY (`idPatient`) REFERENCES `t_patient` (`idPatient`);

--
-- Constraints for table `t_contacthastype`
--
ALTER TABLE `t_contacthastype`
  ADD CONSTRAINT `fkContact` FOREIGN KEY (`fkContact`) REFERENCES `t_contact` (`idContact`);

--
-- Constraints for table `t_diagnosticsbelongtoconsultations`
--
ALTER TABLE `t_diagnosticsbelongtoconsultations`
  ADD CONSTRAINT `t_diagnosticsbelongtoconsultations_ibfk_1` FOREIGN KEY (`fkConsultations`) REFERENCES `t_consultations` (`idConsultations`),
  ADD CONSTRAINT `t_diagnosticsbelongtoconsultations_ibfk_2` FOREIGN KEY (`fkDiagnostics`) REFERENCES `t_diagnostics` (`idDiagnostics`);

--
-- Constraints for table `t_documentbelongtotask`
--
ALTER TABLE `t_documentbelongtotask`
  ADD CONSTRAINT `t_documentBelongToTask_t_task_FK` FOREIGN KEY (`idTask`) REFERENCES `t_task` (`idTask`);

--
-- Constraints for table `t_employees`
--
ALTER TABLE `t_employees`
  ADD CONSTRAINT `t_employees_ibfk_1` FOREIGN KEY (`empCity`) REFERENCES `t_cities` (`id`);

--
-- Constraints for table `t_employerbelongtoappointment`
--
ALTER TABLE `t_employerbelongtoappointment`
  ADD CONSTRAINT `t_employerbelongtoappointment_employers0_FK` FOREIGN KEY (`id`) REFERENCES `t_employees` (`idEmployees`),
  ADD CONSTRAINT `t_employerbelongtoappointment_t_appointment_FK` FOREIGN KEY (`idAppointment`) REFERENCES `t_appointment` (`idAppointment`);

--
-- Constraints for table `t_hasstep`
--
ALTER TABLE `t_hasstep`
  ADD CONSTRAINT `t_hasStep_t_taskStep0_FK` FOREIGN KEY (`idStep`) REFERENCES `t_taskstep` (`idStep`),
  ADD CONSTRAINT `t_hasStep_t_task_FK` FOREIGN KEY (`idTask`) REFERENCES `t_task` (`idTask`);

--
-- Constraints for table `t_insurancebelongtoappointment`
--
ALTER TABLE `t_insurancebelongtoappointment`
  ADD CONSTRAINT `t_insurancebelongtoappointment_insurances0_FK` FOREIGN KEY (`id`) REFERENCES `t_insurances` (`idInsurances`),
  ADD CONSTRAINT `t_insurancebelongtoappointment_t_appointment_FK` FOREIGN KEY (`idAppointment`) REFERENCES `t_appointment` (`idAppointment`);

--
-- Constraints for table `t_insurances`
--
ALTER TABLE `t_insurances`
  ADD CONSTRAINT `t_insurances_ibfk_1` FOREIGN KEY (`insCity`) REFERENCES `t_cities` (`id`);

--
-- Constraints for table `t_invoice`
--
ALTER TABLE `t_invoice`
  ADD CONSTRAINT `t_invoice_fkBankAccount_FK` FOREIGN KEY (`fkBankAccount`) REFERENCES `t_bankaccount` (`idBankAccount`),
  ADD CONSTRAINT `t_invoice_fkDispatchAndInsurance_FK` FOREIGN KEY (`fkDispatchAndInsurance`) REFERENCES `t_dispatchandinsurance` (`idDispatchAndInsurance`),
  ADD CONSTRAINT `t_invoice_fkInvoiceStatus_FK` FOREIGN KEY (`fkInvoiceStatus`) REFERENCES `t_invoicestatus` (`idInvoiceStatus`),
  ADD CONSTRAINT `t_invoice_fkMedicalActor_FK` FOREIGN KEY (`fkMedicalActor`) REFERENCES `t_medicalactor` (`idMedicalActor`),
  ADD CONSTRAINT `t_invoice_fkMedicalEstablishment_FK` FOREIGN KEY (`fkMedicalEstablishment`) REFERENCES `t_medicalestablishment` (`idMedicalEstablishment`),
  ADD CONSTRAINT `t_invoice_fkPatient_FK` FOREIGN KEY (`fkPatient`) REFERENCES `t_patient` (`idPatient`);

--
-- Constraints for table `t_medicalprescription`
--
ALTER TABLE `t_medicalprescription`
  ADD CONSTRAINT `t_medicalprescription_ibfk_1` FOREIGN KEY (`fkConsultations`) REFERENCES `t_consultations` (`idConsultations`),
  ADD CONSTRAINT `t_medicalprescription_ibfk_2` FOREIGN KEY (`fkMedicament`) REFERENCES `t_medicament` (`idMedicament`),
  ADD CONSTRAINT `t_medicalprescription_ibfk_3` FOREIGN KEY (`fkPatients`) REFERENCES `t_patient` (`idPatient`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
