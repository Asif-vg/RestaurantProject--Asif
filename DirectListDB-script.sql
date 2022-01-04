USE [DirectListDB]
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Name], [Text], [UserImage], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Surname]) VALUES (N'b53357e9-781f-4081-8c8f-5ebd04d3388c', N'User', N'Asif', N'Nullam ultricies, velit ut varius molestie, ante metus condimentum nisi, dignissim facilisis turpis ex in libero. Sed porta ante tortor, a pulvinar mi facilisis nec. Proin finibus dolor ac convallis congue.', N'avatar3.png', N'asif@gmail.com', N'ASIF@GMAIL.COM', N'asif@gmail.com', N'ASIF@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKEYEnvih9BosboiF8mMDHVWhcf4c2ttAJ2JV4vBOGhA7q9D62OhiXTAtKhr8B7ATA==', N'EMZS2QJI6FEB73773HHKQM6E4CEETVCD', N'286b8216-484f-4ee3-89a1-cb6ae781c79f', NULL, 0, 0, NULL, 1, 0, N'Quluyev')
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Title], [Content], [Image], [CreatedDate]) VALUES (3, N'Take a Look at Hotels for All Budgets', N'<p>Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.</p><blockquote><p>Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.</p></blockquote><p>In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.</p><p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.</p>', N'd565b422-65cd-4903-a762-b118c47f001c-20211225134031-dp-3.jpg', CAST(N'2018-08-22T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [Image], [CreatedDate]) VALUES (5, N'Take a Look at Hotels for All Budgets', N'<p>Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.</p><blockquote><p>Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.</p></blockquote><p>In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.</p><p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.</p>', N'27bda6f8-c73f-4784-a5f9-4f9920bff6ae-20211225140003-dp-4.jpg', CAST(N'2019-05-12T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Blogs] ([Id], [Title], [Content], [Image], [CreatedDate]) VALUES (6, N'Lorem ipsum qwte is tprew', N'<p>Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.</p><blockquote><p>Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.</p></blockquote><p>In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.</p><p>Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.</p>', N'b06a8b68-1094-4c14-885b-6064542b69b7-20211225140144-dp-2.jpg', CAST(N'2022-01-10T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogComments] ON 

INSERT [dbo].[BlogComments] ([Id], [Name], [Text], [CreatedDate], [Subject], [Email], [BlogId], [ParentId]) VALUES (3, N'Asif', N'Error', CAST(N'2022-01-01T18:36:20.2820396' AS DateTime2), N'Back Project', N'asif@gmail.com', 3, NULL)
INSERT [dbo].[BlogComments] ([Id], [Name], [Text], [CreatedDate], [Subject], [Email], [BlogId], [ParentId]) VALUES (4, N'Adsiz', N'problem', CAST(N'2022-01-01T19:55:19.0764066' AS DateTime2), N'subject', N'adsiz@gmail.com', 3, NULL)
INSERT [dbo].[BlogComments] ([Id], [Name], [Text], [CreatedDate], [Subject], [Email], [BlogId], [ParentId]) VALUES (5, N'Kimse', N'asd', CAST(N'2022-01-03T20:37:10.1116943' AS DateTime2), N'asd', N'kimse@gmail.com', 6, NULL)
SET IDENTITY_INSERT [dbo].[BlogComments] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [ProductName]) VALUES (18, N'Classic Burger')
INSERT [dbo].[Menus] ([Id], [ProductName]) VALUES (19, N'Cheddar Burger')
INSERT [dbo].[Menus] ([Id], [ProductName]) VALUES (20, N'Veggie Burger')
INSERT [dbo].[Menus] ([Id], [ProductName]) VALUES (21, N'Chicken Burger')
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [CreatedDate], [AddressLocation], [LocationNote], [Capacity], [Website]) VALUES (11, N'Tom House', N'4340 Cambridgee Court Natural Dam, Arkansas', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!  Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', CAST(N'2021-12-06T08:00:00.0000000' AS DateTime2), CAST(N'2025-03-28T22:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'4340 Cambridge Court Natural Dam, Arkansas', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', 30, N'http://example.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [CreatedDate], [AddressLocation], [LocationNote], [Capacity], [Website]) VALUES (14, N'Burger House', N'4340 Cambridge Court Natural Dam, Arkansas', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!  Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', CAST(N'2019-11-20T06:00:00.0000000' AS DateTime2), CAST(N'2027-12-22T23:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'4340 Cambridge Court Natural Dam, Arkansas', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.

', 50, N'http://example.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [CreatedDate], [AddressLocation], [LocationNote], [Capacity], [Website]) VALUES (23, N'Hotel Govendor', N'Dingloy Place, Remington, London, EC1V 8BP, United Kingdom', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!  Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', CAST(N'2021-12-07T07:00:00.0000000' AS DateTime2), CAST(N'2023-01-09T16:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Dingloy Place, Remington, London, EC1V 8BP, United Kingdom', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', 100, N'http://chevron.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [CreatedDate], [AddressLocation], [LocationNote], [Capacity], [Website]) VALUES (29, N'Cook', N'Dingloy Place, Remington, London, EC1V 8BP, United Kingdom', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!  Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', CAST(N'2021-12-27T06:00:00.0000000' AS DateTime2), CAST(N'2029-01-30T21:07:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Dingloy Place, Remington, London, EC1V 8BP, United Kingdom', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', 200, N'http://cook.com')
INSERT [dbo].[Restaurants] ([Id], [Name], [Address], [About], [Phone1], [Phone2], [Phone3], [StartTime], [EndTime], [CreatedDate], [AddressLocation], [LocationNote], [Capacity], [Website]) VALUES (30, N'Sezar', N'4340 Cambridge Court Natural Dam, Arkansas', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus!  Lorem ipsum dolor sit amet consectetur adipisicing elit. Placeat rerum doloribus repudiandae nulla odit, omnis ex, a assumenda fugiat quasi neque necessitatibus fugit maiores quis. Quo dolor minus pariatur natus! Lorem ipsum dolor sit amet consectetur adipisicing elit. Blanditiis quis laudantium est pariatur, harum laboriosam odit delectus vitae minima dolorem ipsam repudiandae sunt non. Dolorem adipisci voluptates doloribus voluptatum nihil.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', CAST(N'2021-11-29T07:00:00.0000000' AS DateTime2), CAST(N'2047-12-29T23:00:00.0000000' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'4340 Cambridge Court Natural Dam, Arkansas', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', 500, N'http://sezar.com')
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuToRestaurants] ON 

INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (5, N'Beef, salad, mayonnaise, spicey relish, cheese', 6.0000, 18, 11)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (6, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 6.0000, 19, 11)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (7, N'Panko crumbed and fried, grilled peppers and mushroom', 6.0000, 20, 11)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (8, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 6.0000, 21, 11)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (10, N'Beef, salad, mayonnaise, spicey relish, cheese', 6.0000, 18, 14)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (11, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 6.0000, 19, 14)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (12, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 6.0000, 21, 30)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (13, N'Panko crumbed and fried, grilled peppers and mushroom', 6.0000, 20, 29)
INSERT [dbo].[MenuToRestaurants] ([Id], [Spices], [Price], [MenuId], [RestaurantId]) VALUES (14, N'Panko crumbed and fried, grilled peppers and mushroom', 6.0000, 20, 23)
SET IDENTITY_INSERT [dbo].[MenuToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantFeaturess] ON 

INSERT [dbo].[RestaurantFeaturess] ([Id], [Name]) VALUES (2, N'FREE WIFI INTERNET ACCESS INCLUDED')
INSERT [dbo].[RestaurantFeaturess] ([Id], [Name]) VALUES (3, N'FREE PARKING')
INSERT [dbo].[RestaurantFeaturess] ([Id], [Name]) VALUES (4, N'SWIMMINGPOOL OUTDOOR')
INSERT [dbo].[RestaurantFeaturess] ([Id], [Name]) VALUES (5, N'FAMILY ROOMS')
INSERT [dbo].[RestaurantFeaturess] ([Id], [Name]) VALUES (6, N'NON SMOKING ROOMS')
SET IDENTITY_INSERT [dbo].[RestaurantFeaturess] OFF
GO
SET IDENTITY_INSERT [dbo].[FeatureToRestaurants] ON 

INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (1, 2, 30)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (2, 3, 30)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (3, 4, 30)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (16, 2, 11)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (17, 3, 11)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (18, 4, 11)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (19, 4, 14)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (20, 5, 14)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (21, 2, 23)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (22, 3, 23)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (23, 4, 23)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (24, 5, 23)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (25, 6, 23)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (26, 5, 29)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (27, 6, 29)
SET IDENTITY_INSERT [dbo].[FeatureToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Adminstrators] ON 

INSERT [dbo].[Adminstrators] ([Id], [Name], [Email], [Phone], [Image], [RestaurantId]) VALUES (9, N'John Smith', N'john@gmail.com', N'+49 176 32366261', N'83609b17-6e5a-4a92-82b9-f306cc3fd2a2-20220102210436-avatar2.png', 11)
INSERT [dbo].[Adminstrators] ([Id], [Name], [Email], [Phone], [Image], [RestaurantId]) VALUES (10, N'Stein Albert', N'stein@gmail.com', N'+49 176 32364263', N'29dd0801-4a4b-497c-8488-211d1480d1a2-20220102211037-avatar1.png', 14)
INSERT [dbo].[Adminstrators] ([Id], [Name], [Email], [Phone], [Image], [RestaurantId]) VALUES (11, N'Alexa Melvin', N'alexa@gmail.com', N'+49 176 22364261', N'99f64879-533f-4033-8b49-6e5671c321f1-20220102211122-avatar3.png', 23)
INSERT [dbo].[Adminstrators] ([Id], [Name], [Email], [Phone], [Image], [RestaurantId]) VALUES (12, N'Tom Kelvin', N'tom@gmail.com', N'+49 176 52354261', N'08cf807f-ba55-4509-ad29-9b7fd2d84ac4-20220102211837-avatar3.png', 29)
INSERT [dbo].[Adminstrators] ([Id], [Name], [Email], [Phone], [Image], [RestaurantId]) VALUES (13, N'Albert Bond', N'albert@gmail.com', N'+49 176 32365261', N'28803980-3d82-4b88-b025-9a83fa750e7c-20220102211926-avatar2.png', 30)
SET IDENTITY_INSERT [dbo].[Adminstrators] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [FullName], [GuestCount], [FIN], [CreatedDate], [RestaurantId]) VALUES (3, N'Asif', 2, N'AA12345', CAST(N'2022-01-11T00:00:00.0000000' AS DateTime2), 30)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantComments] ON 

INSERT [dbo].[RestaurantComments] ([Id], [Name], [Text], [CreatedDate], [Subject], [Email], [RestaurantId]) VALUES (1, N'Asif', N'ERROR', CAST(N'2022-01-01T20:18:56.1070930' AS DateTime2), N'Subject', N'asiff@gmail.com', 11)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Text], [CreatedDate], [Subject], [Email], [RestaurantId]) VALUES (2, N'kimse', N'ERROR', CAST(N'2022-01-02T19:55:00.4106657' AS DateTime2), N'nebilim', N'kimse@gmail.com', 29)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Text], [CreatedDate], [Subject], [Email], [RestaurantId]) VALUES (3, N'stein', N'ERROR', CAST(N'2022-01-03T20:38:05.4714124' AS DateTime2), N'Subjectt', N'steinn@gmail.com', 14)
SET IDENTITY_INSERT [dbo].[RestaurantComments] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantImages] ON 

INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (15, N'0000e59b-58b2-4676-bbe5-9037e8f63da9-20211229161944-most-img-2.jpg', 11)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (16, N'8dc2fd76-7456-49d2-985b-6c46328fd72a-20211229161944-most-img-3.jpg', 11)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (17, N'5d719812-ff9c-4545-b1e1-9bb3d8a178cb-20211229202823-most-img-1.jpg', 14)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (18, N'b45eb0ff-1227-4ec6-a86c-94f6a63f15fc-20211229202824-most-img-7.jpg', 14)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (19, N'20ffaefb-ed83-443e-b15d-4c002af4e8fd-20211231161804-most-img-4.jpg', 23)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (23, N'22a0c9cb-0536-4dd9-a0f0-e8bd278faeb2-20220101210755-dp-2.jpg', 29)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (24, N'6a1c1bb9-d4d7-4d7c-91d7-983a511c8530-20220102000852-dp-1.jpg', 30)
SET IDENTITY_INSERT [dbo].[RestaurantImages] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'DINNER')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (2, N'HOTEL')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'SEA FOOD')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[TagToRestaurants] ON 

INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (17, 2, 30)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (18, 3, 30)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (21, 2, 11)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (22, 3, 11)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (23, 2, 14)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (24, 3, 14)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (25, 1, 23)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (26, 2, 23)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (27, 3, 23)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (28, 2, 29)
SET IDENTITY_INSERT [dbo].[TagToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Title], [Content], [Image], [Content2]) VALUES (4, N'Our Goal', N'Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel consectetur, ipsa autem vitae quos ea laborum expedita', N'169d411d-a445-41cb-97c4-c98a17e1350e-20211226230132-about-image.jpg', N'<p>Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem sapiente, fugiat commodi reprehenderit expedita nam nemo</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!</p><p>Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!</p>')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banner] ON 

INSERT [dbo].[Banner] ([Id], [Title], [Page], [BgImage]) VALUES (1, N'Blog Listing', N'Blog', N'title-bar.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Page], [BgImage]) VALUES (2, N'Restaurants', N'Restaurant', N'title-bar.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Page], [BgImage]) VALUES (3, N'About Us', N'About', N'title-bar.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Page], [BgImage]) VALUES (4, N'Contact Us', N'Contact', N'title-bar.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Page], [BgImage]) VALUES (5, N'Blog Detail', N'BlogDetail', N'title-bar.jpg')
INSERT [dbo].[Banner] ([Id], [Title], [Page], [BgImage]) VALUES (6, N'Restaurant Detail', N'RestaurantDetail', N'title-bar.jpg')
SET IDENTITY_INSERT [dbo].[Banner] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FName], [LName], [Subject], [Text], [Email], [CreatedDate]) VALUES (3, N'Asif', N'Quluyev', N'Project', N'Error', N'asifvg@code.edu.az', CAST(N'2022-01-01T17:02:08.7129946' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[DreamPlans] ON 

INSERT [dbo].[DreamPlans] ([Id], [SubTitle], [SubContent], [Icon], [CreatedDate]) VALUES (1, N'Find Interesting Place', N'Proin dapibus nisl ornare diam varius tempus. Aenean a quam luctus, finibus tellus ut, convallis eros sollicitudin turpis.', N'fa fa-search', CAST(N'2021-12-26T18:27:00.0000000' AS DateTime2))
INSERT [dbo].[DreamPlans] ([Id], [SubTitle], [SubContent], [Icon], [CreatedDate]) VALUES (2, N'Contact a Few Owners', N'Maecenas pulvinar, risus in facilisis dignissim, quam nisi hendrerit nulla, id vestibulum metus nullam viverra porta purus.', N'fa fa-phone-square', CAST(N'2021-12-26T18:29:00.0000000' AS DateTime2))
INSERT [dbo].[DreamPlans] ([Id], [SubTitle], [SubContent], [Icon], [CreatedDate]) VALUES (3, N'Make a Reservation', N'Faucibus ante, in porttitor tellus blandit et. Phasellus tincidunt metus lectus sollicitudin feugiat pharetra consectetur.', N'fa fa-user-plus', CAST(N'2021-12-26T18:30:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[DreamPlans] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Address1], [Address2], [Phone1], [Phone2], [Email1], [Email2], [Description], [Logo]) VALUES (1, N'12345 Little Lonsdale St, Melbourne', N'423B, Road Wordwide Country, USA', N' (123) 123-4567', N'+01-1234-567-8900', N'office@example.com', N'htinfotech7@gmail.com', N'Morbi convallis bibendum urna ut viverra. Maecenas quis consequat libero, a feugiat eros. Nunc ut lacinia tortor morbi ultricies laoreet ullamcorper phasellus semper.', N'logo-white.png')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (1, N'twitter', N'fa fa-twitter', N'https://twitter.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (2, N'facebook', N'fa fa-facebook-square', N'https://www.facebook.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (3, N'dribbble', N'fa fa-dribbble', N'https://dribbble.com/')
INSERT [dbo].[Socials] ([Id], [Name], [Icon], [Link]) VALUES (4, N'github', N'fa fa-github', N'https://github.com/')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[Steps] ON 

INSERT [dbo].[Steps] ([Id], [Title], [Content], [Icon]) VALUES (1, N'Plan', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod', N'fa fa-bookmark')
INSERT [dbo].[Steps] ([Id], [Title], [Content], [Icon]) VALUES (2, N'Code', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod', N'fa fa-rocket')
INSERT [dbo].[Steps] ([Id], [Title], [Content], [Icon]) VALUES (3, N'Deliver', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod', N'fa fa-check')
SET IDENTITY_INSERT [dbo].[Steps] OFF
GO
