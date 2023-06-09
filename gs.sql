USE [master]
GO
/****** Object:  Database [GamerShop]    Script Date: 16.06.2021 13:07:02 ******/
CREATE DATABASE [GamerShop]
GO
USE [GamerShop]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[ClientLogin] [nvarchar](50) NULL,
	[ClientPassword] [nvarchar](50) NULL,
	[ClientLastName] [nvarchar](100) NULL,
	[ClientName] [nvarchar](100) NULL,
	[ClientPatronymic] [nvarchar](100) NULL,
	[ClientCityAccommodation] [nvarchar](100) NULL,
	[ClientBirthDate] [date] NULL,
	[IdRole] [tinyint] NULL,
	[ClientIdentification] [int] NULL,
 CONSTRAINT [PK__Client__C1961B33D382D2FE] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Developer]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Developer](
	[IdDeveloper] [tinyint] IDENTITY(1,1) NOT NULL,
	[NameDevCorp] [nvarchar](50) NULL,
	[DevDescription] [nvarchar](1000) NULL,
	[DevDirectorLastName] [nvarchar](100) NULL,
	[DevDirectorName] [nvarchar](100) NULL,
	[DevDirectorPatronymic] [nvarchar](100) NULL,
	[DateOfDevCorpWasFounded] [date] NULL,
 CONSTRAINT [PK__Develope__53BC78CDCAA6ABA7] PRIMARY KEY CLUSTERED 
(
	[IdDeveloper] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Game]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Game](
	[IdGame] [int] IDENTITY(1,1) NOT NULL,
	[GamePhoto] [nvarchar](100) NULL,
	[GameTitle] [nvarchar](50) NULL,
	[IdGenre] [tinyint] NULL,
	[GameDescription] [nvarchar](1000) NULL,
	[IdDeveloper] [tinyint] NULL,
	[IdPublisher] [tinyint] NULL,
	[GameReleaseDate] [date] NULL,
	[GamePrice] [nvarchar](5) NULL,
	[GameEvaluation] [tinyint] NULL,
 CONSTRAINT [PK__Game__9E8BA4109990059E] PRIMARY KEY CLUSTERED 
(
	[IdGame] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[IdGenre] [tinyint] IDENTITY(1,1) NOT NULL,
	[GenreTitle] [nvarchar](50) NULL,
	[GenreDescription] [nvarchar](1000) NULL,
 CONSTRAINT [PK__Genre__E7B673989DCA8701] PRIMARY KEY CLUSTERED 
(
	[IdGenre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Key]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Key](
	[IdKey] [int] IDENTITY(1,1) NOT NULL,
	[IdGame] [int] NULL,
	[Key] [nvarchar](6) NULL,
	[IsSoldOut] [bit] NULL,
 CONSTRAINT [PK__Key__0D974328278545F3] PRIMARY KEY CLUSTERED 
(
	[IdKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[IdPublisher] [tinyint] IDENTITY(1,1) NOT NULL,
	[NamePubCorp] [nvarchar](50) NULL,
	[PubDescription] [nvarchar](1000) NULL,
	[PubDirectorLastName] [nvarchar](100) NULL,
	[PubDirectorName] [nvarchar](100) NULL,
	[PubDirectorPatronymic] [nvarchar](100) NULL,
	[DateOfPubCorpWasFounded] [date] NULL,
 CONSTRAINT [PK__Publishe__F41F8756C88B60C4] PRIMARY KEY CLUSTERED 
(
	[IdPublisher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IdRole] [tinyint] IDENTITY(1,1) NOT NULL,
	[RoleTitle] [nvarchar](50) NULL,
 CONSTRAINT [PK__Role__B436905438729F86] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 16.06.2021 13:07:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[IdSale] [int] IDENTITY(1,1) NOT NULL,
	[IdKey] [int] NULL,
	[IdClient] [int] NULL,
	[SaleDate] [date] NULL,
 CONSTRAINT [PK__Sale__A04F9B37265552F0] PRIMARY KEY CLUSTERED 
(
	[IdSale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([IdClient], [ClientLogin], [ClientPassword], [ClientLastName], [ClientName], [ClientPatronymic], [ClientCityAccommodation], [ClientBirthDate], [IdRole], [ClientIdentification]) VALUES (1, N'azl1337', N'azl1337', N'Рахматуллин', N'Азaт', N'Марсович', N'Россия, Зеленодольск', CAST(N'2001-06-20' AS Date), 1, 431321)
INSERT [dbo].[Client] ([IdClient], [ClientLogin], [ClientPassword], [ClientLastName], [ClientName], [ClientPatronymic], [ClientCityAccommodation], [ClientBirthDate], [IdRole], [ClientIdentification]) VALUES (2, N'krikkirill', N'kirill', N'Арбузов', N'Кирилл', N'Сергеевич', N'Россия, Зеленодольск', CAST(N'2001-06-29' AS Date), 1, 111324)
INSERT [dbo].[Client] ([IdClient], [ClientLogin], [ClientPassword], [ClientLastName], [ClientName], [ClientPatronymic], [ClientCityAccommodation], [ClientBirthDate], [IdRole], [ClientIdentification]) VALUES (3, N'himer', N'hima', N'Кузьмин', N'Эдуард', N'Александрович', N'Россия, Тюмень', CAST(N'1997-02-01' AS Date), 3, 434154)
INSERT [dbo].[Client] ([IdClient], [ClientLogin], [ClientPassword], [ClientLastName], [ClientName], [ClientPatronymic], [ClientCityAccommodation], [ClientBirthDate], [IdRole], [ClientIdentification]) VALUES (4, N'alyoshka02', N'alyo', N'Никишин', N'Алексей', N'Витальевич', N'Россия, Зеленодольск', CAST(N'2002-07-01' AS Date), 1, 876543)
INSERT [dbo].[Client] ([IdClient], [ClientLogin], [ClientPassword], [ClientLastName], [ClientName], [ClientPatronymic], [ClientCityAccommodation], [ClientBirthDate], [IdRole], [ClientIdentification]) VALUES (5, N'billi', N'billi123', N'Панкевич', N'Вадим', N'Андреевич', N'Россия, Тюмень', CAST(N'2003-11-16' AS Date), 3, 435241)
INSERT [dbo].[Client] ([IdClient], [ClientLogin], [ClientPassword], [ClientLastName], [ClientName], [ClientPatronymic], [ClientCityAccommodation], [ClientBirthDate], [IdRole], [ClientIdentification]) VALUES (10, N'danshan', N'dsa', N'Шанский', N'Данил', N'Радикович', N'Россия, Зеленодольск', CAST(N'2001-01-15' AS Date), 3, 275881)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Developer] ON 

INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (1, N'Bandai Namco Entertainment', N'Японская компания, занимающаяся разработкой и изданием видеоигр, также занимается выпуском продукции, такой как видео и музыка, связанной с имеющейся у нее интеллектуальной собственностью.', N'Накамура ', N'Масая', NULL, CAST(N'2006-03-31' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (2, N'FromSoftware', N'Японская компания, специализирующаяся на выпуске видеоигр и основанная 1 ноября 1986 года. Компания известна по таким играм и сериям игр как Armored Core, Demon''s Souls, Dark Souls, Bloodborne, Sekiro, King’s Field, Otogi.', N'Миядзаки', N'Хидэтака', NULL, CAST(N'1986-11-01' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (3, N'CD Projekt Red', N'Польская холдинговая компания, издатель, локализатор и разработчик компьютерных игр.', N'Кичиньский', N'Адам ', NULL, CAST(N'1994-05-31' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (4, N'Bluehole Studio', N'Корейская компания, разработчик компьютерных игр в жанре MMORPG, основана в марте 2007 года, основатель компании Ганг-Сеок Ким (англ. Gang-Seok Kim)', N'Ким', N'ГанСок', NULL, CAST(N'2007-03-01' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (5, N'Ubisoft Montreal', N'Студия-разработчик игр, расположенная в Канаде, Монреаль, Квебек. Основана в качестве дочерней компании Ubisoft в 1997 году, первоначально развивала малые проекты, в настоящее время является одной из крупнейших в мире студией-разработчиком игр, насчитывающей более 3000 сотрудников[1], отвечает за развитие серий игр Assassin’s Creed, Far Cry и Watch Dogs.', N'Маллат', N'Яннис', NULL, CAST(N'1997-04-25' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (6, N'Blizzard', N'Американский разработчик и издатель компьютерных игр. Компания была основана 8 февраля 1991 года тремя выпускниками Калифорнийского университета в Лос-Анджелесе: Алленом Адамом, Фрэнком Пирсом и Майком Морхеймом.', N'Аллен', N'Адам', NULL, CAST(N'1991-02-08' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (7, N'Hopoo Games', N'Компания создающая инди игры.', N'Друмод', N'Дункан', NULL, CAST(N'2012-07-22' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (9, N'Klei Entertainment', N'Klei Entertainment — студия по разработке игр, расположенная в Ванкувере.', N'Джейми', N'Чен', NULL, CAST(N'2005-07-09' AS Date))
INSERT [dbo].[Developer] ([IdDeveloper], [NameDevCorp], [DevDescription], [DevDirectorLastName], [DevDirectorName], [DevDirectorPatronymic], [DateOfDevCorpWasFounded]) VALUES (11, N'Motion Twin', N'Независимая студия, специализирующаяся на онлайн-видеоиграх.', N'Стоулс', N'Бернард ', NULL, CAST(N'2001-08-06' AS Date))
SET IDENTITY_INSERT [dbo].[Developer] OFF
GO
SET IDENTITY_INSERT [dbo].[Game] ON 

INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (1, N'ds1.jpg', N'Dark Souls', 1, N'Компьютерная игра в жанре action/RPG с открытым миром, разработанная японской компанией From Software и выпущенная в 2011 году для PlayStation 3 и Xbox 360. В Японии издателем игры выступала сама From Software; на международном рынке игру издавала компания Namco Bandai Games. Dark Souls, изначально известная под рабочим названием Project Dark, является идейным наследником игры Demon''s Souls и второй частью в серии Souls.', 2, 1, CAST(N'2011-10-22' AS Date), N'699', 9)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (3, N'pubg.jpg', N'PlayerUnknown’s Battlegrounds', 4, N'Многопользовательская онлайн-игра в жанре королевской битвы, разрабатываемая и издаваемая студией PUBG Corporation, дочерней компанией корейского издателя Bluehole.', 4, 3, CAST(N'2016-06-27' AS Date), N'949', 6)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (4, N'ds3.jpg', N'Dark Souls III', 1, N'Компьютерная игра в жанре Action/RPG, разработанная компанией FromSoftware для платформ Windows, PlayStation 4 и Xbox One.', 2, 1, CAST(N'2016-03-24' AS Date), N'1999', 9)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (5, N'witcher3.jpg', N'Ведьмак 3: Дикая Охота', 1, N'Мультиплатформенная компьютерная игра в жанре action/RPG, разработанная польской студией CD Projekt RED по мотивам серии романов «Ведьмак» польского писателя Анджея Сапковского, выпущенная в 2015 году для Windows, PlayStation 4 и Xbox One.', 3, 1, CAST(N'2015-05-18' AS Date), N'1199', 10)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (6, N'r6s.jpg', N'Tom Clancy’s Rainbow Six Siege', 2, N'Тактический шутер от первого лица, разработанный Ubisoft для Microsoft Windows, Xbox One и PlayStation 4.', 5, 4, CAST(N'2015-12-01' AS Date), N'829', 9)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (7, N'overwatch.jpg', N'Overwatch', 2, N'Многопользовательская компьютерная игра в жанре шутера от первого лица, разработанная и выпущенная компанией Blizzard Entertainment в 2016 году для Windows, PlayStation 4 и Xbox One и в 2019 году для Nintendo Switch.', 6, 5, CAST(N'2016-06-26' AS Date), N'999', 9)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (8, N'war3reforged.png', N'Warcraft III: Reforged', 6, N'Компьютерная игра в жанре стратегии в реальном времени, разработанная Blizzard Entertainment и Lemon Sky Studios и выпущенная Blizzard Entertainment в 2020 году.', 6, 5, CAST(N'2020-01-29' AS Date), N'1299', 6)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (9, N'ror.png', N'Risk of Rain', 5, N'Это платформенная видеоигра 2013 года,включающаяэлементы Metroidvania и roguelike , разработанная командой из двух студентов Вашингтонского университета под названием Hopoo Games. ', 7, 7, CAST(N'2013-11-08' AS Date), N'249', 9)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (10, N'oxygen.jpg', N'Oxygen Not Included ', 5, N'Oxygen Not Included является симулятором выживания в космической колонии, где игрок должен управлять её поселенцами-колонистами (называемых в игре дупликантами), помогая им рыть, строить и поддерживать базу, находящуюся в астероиде, который игрок может самостоятельно выбрать из существующих в игре. Для этого нужно добывать воду, тепло, еду и кислород для поддержания жизнеспособности, а также делать колонистов счастливыми. Игра задействует процедурную генерацию и систему крафта. Каждый из дупликантов имеет свои характеристики, от которых зависят его способности к той или иной деятельности.', 9, 8, CAST(N'2019-07-30' AS Date), N'449', 10)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (12, N'tboi.png', N'The Binding of Isaac: Afterbirth +', 5, N'When Isaac’s mother starts hearing the voice of God demanding a sacrifice be made to prove her faith, Isaac escapes into the basement facing droves of deranged enemies, lost brothers and sisters, his fears, and eventually his mother.', 1, 1, CAST(N'2014-11-04' AS Date), N'699', 10)
INSERT [dbo].[Game] ([IdGame], [GamePhoto], [GameTitle], [IdGenre], [GameDescription], [IdDeveloper], [IdPublisher], [GameReleaseDate], [GamePrice], [GameEvaluation]) VALUES (13, N'deadCells.jpg', N'Dead Cells', 5, N'Dead Cells — это экшн-платформер в жанре Rogue-lite и Metroidvania. Вас ждет огромный, постоянно меняющийся замок... Если, конечно, вы сможете победить тех, кто встанет у вас на пути, в 2D-схватках в стиле Souls-lite. Без сохранений. Убивайте, умирайте, учитесь и пробуйте снова', 11, 11, CAST(N'2018-08-07' AS Date), N'499', 10)
SET IDENTITY_INSERT [dbo].[Game] OFF
GO
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([IdGenre], [GenreTitle], [GenreDescription]) VALUES (1, N'RPG', N'Жанр компьютерных игр, основанный на элементах игрового процесса традиционных настольных ролевых игр. В ролевой игре игрок управляет одним или несколькими персонажами, каждый из которых описан набором численных характеристик, списком способностей и умений; примерами таких характеристик могут быть очки здоровья (англ. hit points, HP), показатели силы, ловкости, интеллекта, защиты, уклонения, уровень развития того или иного навыка и т. п.')
INSERT [dbo].[Genre] ([IdGenre], [GenreTitle], [GenreDescription]) VALUES (2, N'Shooter', N'Жанр компьютерных игр. На момент зарождения жанра за рубежом укрепилось слово «шутер», как вариант описания игрового процесса и перевод для слова shooter, в России и некоторых других странах постсоветского пространства жанр изначально был назван как «стрелялка»[1].')
INSERT [dbo].[Genre] ([IdGenre], [GenreTitle], [GenreDescription]) VALUES (3, N'MOBA (Multiplayer Online Battle Arena)

', N'Жанр компьютерных игр, сочетающий в себе элементы стратегий в реальном времени и компьютерных ролевых игр и выделяющийся схожестью с DotA — пользовательской картой (модификацией) Warcraft III: The Frozen Throne.')
INSERT [dbo].[Genre] ([IdGenre], [GenreTitle], [GenreDescription]) VALUES (4, N'Battle Royale
', N'Один из жанров массовых многопользовательских онлайн-игр, совмещающий в себе элементы симулятора выживания с режимом last man standing. «Королевская битва» сталкивает большое количество управляемых игроками персонажей с минимальным набором снаряжения на ограниченной карте; игроки должны искать на карте оружие и уничтожать противников, пока в игре не останется только один. Характерной особенностью «королевской битвы» является уменьшающаяся по мере игры «безопасная зона»: чем дольше длится матч, тем меньшая часть карты остаётся доступной для игроков. Само название жанра восходит к роману «Королевская битва» японского писателя Косюна Таками и его экранизации.')
INSERT [dbo].[Genre] ([IdGenre], [GenreTitle], [GenreDescription]) VALUES (5, N'Platform', N'Жанр компьютерных игр, в которых основной чертой игрового процесса является прыгание по платформам, лазанье по лестницам, собирание предметов, обычно необходимых для завершения уровня.')
INSERT [dbo].[Genre] ([IdGenre], [GenreTitle], [GenreDescription]) VALUES (6, N'Strategy', N'общий, недетализированный план, охватывающий длительный период времени, способ достижения сложной цели, позднее вообще какой-либо деятельности человека. Задачей стратегии является эффективное использование наличных ресурсов для достижения основной цели (стратегия как способ действий становится особо необходимой в ситуации, когда для прямого достижения основной цели недостаточно наличных ресурсов).')
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
SET IDENTITY_INSERT [dbo].[Key] ON 

INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (1, 1, N'5u84tr', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (3, 3, N'4x447z', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (4, 4, N'jgjlw3', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (5, 5, N'wl40mz', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (6, 6, N'mluns8', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (7, 7, N'pm7w9p', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (8, 8, N'q6hkw8', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (9, 3, N'5t0o2e', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (10, 3, N'zeras6', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (11, 5, N'ry65pf', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (12, 7, N'r3v8ra', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (15, 4, N'tyhr91', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (16, 4, N'5tyh65', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (17, 8, N'iyto8g', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (18, 1, N'657utm', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (19, 6, N'gjtu4q', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (21, 10, N'vI4Azh', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (24, 10, N'o6BlT4', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (25, 10, N'nNNH8r', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (28, 9, N'FZg7D9', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (29, 9, N'E2z0B8', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (30, 13, N'2GBdE8', 1)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (31, 10, N'57HyN6', 0)
INSERT [dbo].[Key] ([IdKey], [IdGame], [Key], [IsSoldOut]) VALUES (32, 12, N'gth23k', 0)
SET IDENTITY_INSERT [dbo].[Key] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (1, N'Bandai Namco Entertainment', N'Японская компания, занимающаяся разработкой и изданием видеоигр, также занимается выпуском продукции, такой как видео и музыка, связанной с имеющейся у нее интеллектуальной собственностью.', N'Накамура ', N'Масая', NULL, CAST(N'2006-03-31' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (2, N'FromSoftware', N'Японская компания, специализирующаяся на выпуске видеоигр и основанная 1 ноября 1986 года. Компания известна по таким играм и сериям игр как Armored Core, Demon''s Souls, Dark Souls, Bloodborne, Sekiro, King’s Field, Otogi.', N'Миядзаки', N'Хидэтака', NULL, CAST(N'1986-11-01' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (3, N'Bluehole Studio', N'Корейская компания, разработчик компьютерных игр в жанре MMORPG, основана в марте 2007 года, основатель компании Ганг-Сеок Ким (англ. Gang-Seok Kim)', N'Ким', N'ГанСок', NULL, CAST(N'2007-03-01' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (4, N'Ubisoft', N'Французская компания, специализирующаяся на разработке и издании компьютерных игр, главный офис которой располагается в Монтрёй, Франция.', N'Корр', N'Алан', NULL, CAST(N'1986-09-06' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (5, N'Blizzard', N'Американский разработчик и издатель компьютерных игр. Компания была основана 8 февраля 1991 года тремя выпускниками Калифорнийского университета в Лос-Анджелесе: Алленом Адамом, Фрэнком Пирсом и Майком Морхеймом.', N'Аллен', N'Адам', NULL, CAST(N'1991-02-08' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (7, N'Chucklefish', N'Британский разработчик и издатель видеоигр, базирующийся в Лондоне . Основанная в 2011 году Финном Брайсом, компания специализируется на играх в ретро-стиле.', N'Брайс', N'Финн', NULL, CAST(N'2011-10-19' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (8, N'Klei Entertainment', N'Klei Entertainment — студия по разработке игр, расположенная в Ванкувере.', N'Джейми', N'Чен', NULL, CAST(N'2005-07-09' AS Date))
INSERT [dbo].[Publisher] ([IdPublisher], [NamePubCorp], [PubDescription], [PubDirectorLastName], [PubDirectorName], [PubDirectorPatronymic], [DateOfPubCorpWasFounded]) VALUES (11, N'Motion Twin', N'Независимая студия, специализирующаяся на онлайн-видеоиграх.', N'Стоулc', N'Бернард', NULL, CAST(N'2001-08-06' AS Date))
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([IdRole], [RoleTitle]) VALUES (1, N'Администратор')
INSERT [dbo].[Role] ([IdRole], [RoleTitle]) VALUES (3, N'Пользователь')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Sale] ON 

INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (1, 1, 1, CAST(N'2020-11-28' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (2, 3, 3, CAST(N'2021-01-13' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (4, 4, 2, CAST(N'2021-01-14' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (5, 15, 1, CAST(N'2021-02-17' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (6, 7, 3, CAST(N'2021-02-17' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (7, 21, 4, CAST(N'2021-02-27' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (8, 24, 1, CAST(N'2021-02-27' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (9, 28, 1, CAST(N'2021-02-27' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (10, 29, 2, CAST(N'2021-02-27' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (11, 30, 5, CAST(N'2021-02-27' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (12, 25, 3, CAST(N'2021-02-27' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (13, 18, NULL, CAST(N'2021-02-28' AS Date))
INSERT [dbo].[Sale] ([IdSale], [IdKey], [IdClient], [SaleDate]) VALUES (14, 5, NULL, CAST(N'2021-06-02' AS Date))
SET IDENTITY_INSERT [dbo].[Sale] OFF
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK__Client__IdRole__59063A47] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK__Client__IdRole__59063A47]
GO
ALTER TABLE [dbo].[Game]  WITH CHECK ADD  CONSTRAINT [FK__Game__IdDevelope__5070F446] FOREIGN KEY([IdDeveloper])
REFERENCES [dbo].[Developer] ([IdDeveloper])
GO
ALTER TABLE [dbo].[Game] CHECK CONSTRAINT [FK__Game__IdDevelope__5070F446]
GO
ALTER TABLE [dbo].[Game]  WITH CHECK ADD  CONSTRAINT [FK__Game__IdGenre__4F7CD00D] FOREIGN KEY([IdGenre])
REFERENCES [dbo].[Genre] ([IdGenre])
GO
ALTER TABLE [dbo].[Game] CHECK CONSTRAINT [FK__Game__IdGenre__4F7CD00D]
GO
ALTER TABLE [dbo].[Game]  WITH CHECK ADD  CONSTRAINT [FK__Game__IdPublishe__5165187F] FOREIGN KEY([IdPublisher])
REFERENCES [dbo].[Publisher] ([IdPublisher])
GO
ALTER TABLE [dbo].[Game] CHECK CONSTRAINT [FK__Game__IdPublishe__5165187F]
GO
ALTER TABLE [dbo].[Key]  WITH CHECK ADD  CONSTRAINT [FK__Key__IdGame__5CD6CB2B] FOREIGN KEY([IdGame])
REFERENCES [dbo].[Game] ([IdGame])
GO
ALTER TABLE [dbo].[Key] CHECK CONSTRAINT [FK__Key__IdGame__5CD6CB2B]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK__Sale__IdClient__6B24EA82] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK__Sale__IdClient__6B24EA82]
GO
ALTER TABLE [dbo].[Sale]  WITH CHECK ADD  CONSTRAINT [FK__Sale__IdKey__6A30C649] FOREIGN KEY([IdKey])
REFERENCES [dbo].[Key] ([IdKey])
GO
ALTER TABLE [dbo].[Sale] CHECK CONSTRAINT [FK__Sale__IdKey__6A30C649]
GO
USE [master]
GO
ALTER DATABASE [GamerShop] SET  READ_WRITE 
GO
