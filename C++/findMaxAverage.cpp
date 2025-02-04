#include "findMaxAverage.h"
#include <vector>
#include <list>
#include <limits>
using namespace std;
double findMaxAverageSub(vector<int>& nums, int k) {
	//divede nums into two
	int numSize = nums.size();
	double currentSum = 0;
	for (int i = 0; i < k; i++) {
		currentSum += nums[i];
	}
	double maxSum = currentSum;
	for (int i = k; i < numSize; i++) {
		//subtract first num added to current sum and add a new num to see if that avg is higher
		currentSum = currentSum - nums[i - k] + nums[i];

		if (currentSum > maxSum) {
			maxSum = currentSum;
		}
	}
	return maxSum / k;
}