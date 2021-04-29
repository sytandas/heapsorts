#!/bin/zsh
start=`date +%s`

printf "\nRunning the C version : \n"
rm -f a.out && gcc heapsort.c && ./a.out && rm -f a.out


printf "\nRunning the Python version : \n"
python3 heapsort.py


printf "\nRunning the C++ version : \n"
rm -f a.out && g++ heapsort.cpp && ./a.out && rm -f a.out

end=`date +%s`

runtime=$((end-start))

printf "\n"

echo "Script ran in $runtime seconds"
