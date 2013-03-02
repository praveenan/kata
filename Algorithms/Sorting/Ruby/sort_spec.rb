require './sort.rb'

describe Sort, "#quicksort" do
  max = 1_000_000

  before(:each) do
    @array = Array.new(max) { |i| Random.rand(max) }
  end

  it "sorts array with quick sort algorithm" do
    expected = @array.sort
    Sort.quicksort @array
    @array.should == expected
  end
end