class Sort

  def self.quicksort(array, from=0, to=nil)

    if to.nil?
      to = array.length - 1
    end

    return if from > to

    min = from
    max = to

    pivot = array[from]

    while min <= max
      while array[min] < pivot
        min += 1
      end

      while array[max] > pivot
        max -= 1
      end

      if min < max
        temp = array[min]
        array[min] = array[max]
        array[max] = temp
      end

      if min <= max
        min += 1
        max -= 1
      end

    end

    quicksort array, from, max
    quicksort array, min, to

  end

end