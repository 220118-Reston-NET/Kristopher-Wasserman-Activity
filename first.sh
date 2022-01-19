# This is  comment to add more Information to your code
#  echo does nothing

#echo Testing

# Varia# They are a way for us to store information for our code to use at a later time

msg="Hello World" # a equal sign is a way for us to create variables to store some information
echo $msg # syntax is the way we can call on a variable

# ControlFlow
# They are a way  for us to tell the program what line of code we want to run
# or how many time we want to run that line of code

# If statement
# Like in english word if, it will only run the line of code if the condition is met

ten=10
five=5
thirtenn=13

# 10>5 then run theses lines of code
echo "===First if==="
if [ "$ten -ge $five" ]
	then
		echo "greater!"
		echo "$ten > $five"
fi

# 5 > 10 then run these lines of code
echo "===Second If==="
if [ "$five -ge $ten" ]
	then
		echo "lesser!"
		echo "$five > $ten"
fi

#gives a second chance to check which is greater
if [ "$five" -ge "$ten" ]
	then
		echo "lesser!"
		echo "$five > $ten"
elif [ "$ten" -ge "$five" ]
	then 
		echo "Greater!"
		echo "$ten > $five"
fi

#For Loop
# will repeat the amount of code x amount of time (you determine how many time)
# Useful if you  knoe how many time you want to repeat your code

echo "===For Loop==="
for num in 1 2 3 4 5
do
	echo "Repeating"
	echo $num
done

echo " ===Second Loop==="
for num in {1..10}
do
	echo $num
done

# While Loop
# will repeat the code multiple times as long as the condition is true

echo "===While Loop==="
while [ "$ten" -ge "$five" ]
do
	echo "Greater!"
	echo $five
	five=$(($five+1))
done

# Input and Output
# we can ask the input from the user that is currently using  the shell

echo "What is your name"
	read name
	echo "hello $name, Welcome to our company"
# Combine everything to creat a ment interdace of our termainal that 
# will ask the user for information and process that info based on  what they ask

clear #this will clear our terminal
repeat="true"
while [ "$repect" == ture ]
do
echo "Welcome to the company@!"
echo "What do you want to do today"
echo "Enter 1 if you want to add two numbers"
echo "Enter 2 if you want to exit the program"
read ans

if[ "$ans" == "1" ]
then
	echo "Give 2 numbers"
	read num1
	read num2
	echo "your number $(($num1+$num2))"
	echo "Press Enter to continue"
	read  fgdhsghd
elif [ "$ans2" == "2" ]
then
	echo "Goodbye!"
	repect = "false"
else
	echo "Envalid Option"
fi

clear
done
