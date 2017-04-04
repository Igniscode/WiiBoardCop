FID = fopen('E:/선종이형앞으로.txt', 'r');
data1= fscanf(FID, '%f\t%f\t', [2, Inf]);
FID = fopen('E:/선종이형뒤로.txt', 'r');
data2= fscanf(FID, '%f\t%f\t', [2, Inf]);
FID = fopen('E:/선종이형안잡고.txt', 'r');
data3= fscanf(FID, '%f\t%f\t', [2, Inf]);
FID = fopen('E:/나도한번.txt', 'r');
data4= fscanf(FID, '%f\t%f\t', [2, Inf]);
FID = fopen('E:/서있기.txt', 'r');
data5= fscanf(FID, '%f\t%f\t', [2, Inf]);


fclose(FID);
figure(1);
comet(data1(1,:),data1(2,:))
figure(2);
comet(data2(1,:),data2(2,:))
figure(3);
comet(data3(1,:),data3(2,:))
figure(4);
comet(data4(1,:),data4(2,:))
figure(5);
comet(data5(1,:),data5(2,:))

