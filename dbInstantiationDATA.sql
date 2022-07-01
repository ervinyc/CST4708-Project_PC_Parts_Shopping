DELETE FROM Orders;
DELETE FROM Transactions;
DELETE FROM Payment;
DELETE FROM Admin;
DELETE FROM Customer;
DELETE FROM Item;

Insert into Admin Values(001,'AO','123456','Alpha','B','Omega');

Insert into Customer Values(001,'captainT@lol.com', 'Shrooms666','Teemo','S','Yordle','6666666666');

Insert into Payment Values(001,001,'Teemo Yordle','1234567899996666',06,2026,666,'69 Toxic St.','Bandle City','VL',66066);
																																				
Insert into Item Values(001,'Core i7-12700K','CPU', 384.98, 'Intel','Core i7 12th Gen Alder Lake 12-Core (8P+4E) 3.6 GHz LGA 1700 125W Intel UHD Graphics 770 Desktop Processor','https://c1.neweggimages.com/ProductImageOriginal/19-118-343-05.jpg');
Insert into Item Values(002,'Core i5-12600K','CPU',278.98, 'Intel', 'Core i5 12th Gen Alder Lake 10-Core (6P+4E) 3.7 GHz LGA 1700 125W Intel UHD Graphics 770 Desktop Processor','https://c1.neweggimages.com/ProductImageCompressAll1280/19-118-347-05.jpg');
Insert into Item Values(003,'Ryzen 5 5600X','CPU',228.98, 'AMD', 'Ryzen 5 5000 Series Vermeer (Zen 3) 6-Core 3.7 GHz Socket AM4 65W Desktop Processor','https://c1.neweggimages.com/ProductImageCompressAll1280/19-113-666-V01.jpg');
Insert into Item Values(004,'Ryzen 9 5900X','CPU',488.99, 'AMD', 'Ryzen 9 5000 Series Vermeer (Zen 3) 12-Core 3.7 GHz Socket AM4 105W Desktop Processor - 100-100000061WOF','https://c1.neweggimages.com/ProductImageCompressAll1280/19-113-664-V01.jpg');
Insert into Item Values(005,'RTX 3080','GPU',1329.99, 'Nvidia', 'EVGA - RTX 3080 12GB FTW3 ULTRA GAMING GDDR6X PCI Express 4.0 LHR','https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6494/6494860_sd.jpg');
Insert into Item Values(006,'RTX 3070TI','GPU',1049.99, 'Nvidia', 'ASUS - NVIDIA GeForce RTX 3070TI 8GB GDDR6X PCI Express 4.0 Graphics Card - Black','https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6467/6467838cv18d.jpg');
Insert into Item Values(007,'RX 6600 XT','GPU',599.99, 'AMD', 'MSI - AMD Radeon RX 6600 XT MECH 2X 8G OC GDDR6 PCI Express 4.0 Gaming Graphics Card - Black','https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6476/6476228_sd.jpg');
Insert into Item Values(008,'RX 6800','GPU',1179.99, 'AMD', 'GIGABYTE - AMD Radeon RX 6800 GAMING OC 16GB GDDR6 PCI Express 4.0 Graphics Card','https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6453/6453897_sd.jpg');
Insert into Item Values(009,'ROG Strix Z690-E Gaming','MB',469.99 , 'ASUS', 'WiFi 6E LGA 1700 Intel 12th Gen ATX Gaming Motherboard- PCIe 5.0, DDR5, 18+1 Power Stages, 2.5 Gb LAN, Bluetooth v5.2','https://c1.neweggimages.com/ProductImageOriginal/13-119-512-V01.jpg');
Insert into Item Values(010,'MPG X570S CARBON MAX','MB',329.98 , 'MSI', 'WIFI AM4 AMD X570 SATA 6Gb/s HDMI ATX AMD Motherboard','https://c1.neweggimages.com/ProductImageCompressAll1280/13-144-493-06.jpg');
Insert into Item Values(011,'Z690 AORUS ELITE AX','MB',239.99 , 'GIGABYTE', 'DDR4 LGA 1700 Intel Z690 ATX Motherboard with DDR4, Quad M.2, PCIe 5.0, USB 3.2 Gen2X2 Type-C, WiFi 6, 2.5GbE LAN','https://c1.neweggimages.com/ProductImageCompressAll1280/13-145-350-05.jpg');
Insert into Item Values(012,'B450M PRO4 R2.0','MB',69.99 , 'ASROCK', 'AM4 AMD Promontory B450 SATA 6Gb/s Micro ATX AMD Motherboard','https://c1.neweggimages.com/ProductImageCompressAll1280/13-157-973-02.jpg');

Insert into Transactions Values(001,001,001,2378.8752);

Insert into Orders Values(001,001,001);
Insert into Orders Values(002,001,005);
Insert into Orders Values(003,001,009);