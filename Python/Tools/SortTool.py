
class SortTool:
    
    @staticmethod
    def swap(nums,source,tar):
        tmp=nums[source]
        nums[source]=nums[tar]
        nums[tar]=tmp
        pass