#Visiting Spongbob squarepants home in bikkin bottom app
#made as a giggle and for kids
#made by Kris Wasserman
#As one enters the big blue as arrives in Bikkin Bottom
#the menu

echo "Welcome"
echo "My name is Eugne Karb0s" #Krabs introduces himself and asks for a name
echo "What can we call you?"
        read name
echo "Welcome $name to Bikkin Bottom"
repeat="true"
while [ "$repeat" == true ]
do

echo "What would yee like to do?"
echo "Enter 1 to go see Sandy"
echo "Enter 2 to throw eggs at Squidward's house"
echo "Enter 3 to visit SpongBob"
echo "Enter 4 to say hello to Patrick(he might not understand a Hi)"
echo "Enter 5 to hang out with Me at the Krusty Krab"
echo " or if you are all done visiting Bikkin Bottom enter 6"

        read  ans

	if [ "$ans" == "1" ]
	then
		 echo "You walked over to Sandy's treehouse to see if she was home,"
		 echo  "She was home and excited that you stopped by"
		  echo "Choose again"
			read  something
	elif [ "$ans" == "2" ]
	then
			echo "You headed over to grumpy old Squidward's house and found no one home"
			echo "So you decided to throw eggs at his house and ran"
			echo "Choose again"
			read something	
	elif [ "$ans" == "3" ]
	then
			echo "You caught Spongbob just in time, He has to go to work "
			echo "Choose again"
			read Something
	elif [ "$ans" == "4" ]
	then
			echo "You stopped by Patrick's house and said Hi but all he was worried about was eating a kraby patty\n so you left"
			echo "Choose Somthing"
			read  something
	elif [ "$ans" == "5" ]
	then
			echo "You got hungry so you decided to go to the Krusty Krabs to get a bit to eat.\n Upon arrival you saw the whole Bikkin Bottom gang"
			echo "You sat at the table with Mr.Krabs and talked for a while"
	 		echo "Choose Again"
			read  Something
	elif [ "$ans" == "6" ]
	then
			echo "Do you have to leave so soon, Owell $name come back soon and thanks for Visiting Bikkin Bottom"
			repeat="false"
			read exi

	else
			echo "Boyo, Thats not an option"
			read a
fi

clear
done

