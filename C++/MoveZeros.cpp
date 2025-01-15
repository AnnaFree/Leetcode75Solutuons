#include "MoveZeros.h"
void moveZeroes(std::vector<int>& nums) {
    int pos = 0;  //position of last known number
    for (int i = 0; i < nums.size(); i++) {
        if (nums[i] != 0) {
            //swap with last known zero
            if (i != pos) {
                nums[pos] = nums[i];
                nums[i] = 0;
            }
            pos++;  //updates position of number to next prospective position to swap with any future zeros
        }
    }
}