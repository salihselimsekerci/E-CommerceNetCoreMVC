// Call the dataTables jQuery plugin
$(document).ready(function () {
    $('#dataTable').DataTable({
		language: {
			"sDecimal": ",",
			"sEmptyTable": "Tabloda herhangi bir veri mevcut degil",
			"sInfo": "_TOTAL_ kayittan _START_ - _END_ arasindaki kayitlar gosteriliyor",
			"sInfoEmpty": "Kayit yok",
			"sInfoFiltered": "(_MAX_ kayit icerisinden bulunan)",
			"sInfoThousands": ".",
			"sLengthMenu": "Sayfada _MENU_ kayit goster",
			"sLoadingRecords": "Yukleniyor...",
			"sProcessing": "isleniyor...",
			"sSearch": "Ara:",
			"sZeroRecords": "Eslesen kayit bulunamadi",
			"oPaginate": {
				"sFirst": "Ilk",
				"sLast": "Son",
				"sNext": "Sonraki",
				"sPrevious": "Onceki"
			},
			"oAria": {
				"sSortAscending": ": artan sutun siralamasini aktiflestir",
				"sSortDescending": ": azalan sutun siralamasini aktiflestir"
			},
			"select": {
				"rows": {
					"_": "%d kayit secildi",
					"1": "1 kayit secildi"
				}
			}
		}
    });

    $('dataTable2').dataTable({ searching: false, paging: false, info: false });

});


