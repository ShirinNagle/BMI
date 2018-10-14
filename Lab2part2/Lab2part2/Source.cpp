#include <stdio.h>

void main()
{
	/*int noOfResults, i;

	printf("Please enter the amount of students reults you would like to enter\n");
	scanf("%d", &noOfResults);
	printf("The amount of student results entered is:%d\n", noOfResults);

	for (i = 0; i < noOfResults; i++)*/
	

		float exam, lab, assignment;
		float result;
		char grade;

		printf("Please enter marks for exam\n");
		scanf("%f", &exam);
		/*printf("The exam result entered is %d\n", exam);*/

		printf("Please enter marks for lab\n");
		scanf("%f", &lab);
		/*printf("The lab result entered is %d\n", lab);*/

		printf("Please enter marks for assignment\n");
		scanf("%f", &assignment);
		/*printf("The assignment result entered is %d\n", assignment);*/

		result = (exam * 0.6) + (lab *0.1) + (assignment*0.3);

		

		if (result >= 70)
		{
			grade = 'A';
			printf("The final result is %.2f which is grade %c\n", result, grade);
		}
		else if (result >= 60)
		{
			grade = 'B';
			printf("The final result is %.2f which is grade %c\n", result, grade);
		}
		else if (result >= 50)
		{
			grade = 'C';
			printf("The final result is %.2f which is grade %c\n", result, grade);
		}
		else if (result >= 40)
		{
			grade = 'D';
			printf("The final result is %.2f which is grade %c\n", result, grade);
		}
		else
		{
			grade = 'E';
			printf("The final result is %.2f which is grade %c\n", result, grade);
		}

		
	



	





}